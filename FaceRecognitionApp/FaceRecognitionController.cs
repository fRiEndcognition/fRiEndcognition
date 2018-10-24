using Luxand;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

class FaceRecognitionController
{
    public struct RectInfo
    {
        public int x;
        public int y;
        public int w;

        public RectInfo(int x, int y, int w)
        {
            this.x = x;
            this.y = y;
            this.w = w;
        }
    }

    public long[] IDs;
    public long faceCount = 0;
    public int tracker = 0;
    private int mouseX = 0;
    private int mouseY = 0;
    private int formX = 0;
    private int formY = 0;

    private int framesToSave = 10;

    private Dictionary<long, Queue<RectInfo>> rectInfoDictionary;

    public void Initialize(Point location)
    {
        tracker = 0;

        DataController.Instance().LoadFaceData(ref tracker);

        int err = 0;
        FSDK.SetTrackerMultipleParameters(tracker, "HandleArbitraryRotations=false; DetermineFaceRotationAngle=false; InternalResizeWidth=300; FaceDetectionThreshold=5;", ref err);

        rectInfoDictionary = new Dictionary<long, Queue<RectInfo>>();

        formX = location.X;
        formY = location.Y;
    }

    public void Update(FSDK.CImage image, Image frameImage, bool recogniseFacialFeatures)
    {
        FSDK.FeedFrame(tracker, 0, image.ImageHandle, ref faceCount, out IDs, sizeof(long) * 256);
        Array.Resize(ref IDs, (int)faceCount);

        Graphics graphics = Graphics.FromImage(frameImage);

        for (int i = 0; i < IDs.Length; ++i)
        {
            if (recogniseFacialFeatures == true)
            {
                FSDK.TPoint[] facialFeatures;
                FSDK.GetTrackerFacialFeatures(tracker, 0, IDs[i], out facialFeatures);
                foreach (FSDK.TPoint point in facialFeatures)
                    graphics.FillEllipse(Brushes.Blue, point.x, point.y, 5, 5);
                
            }
            else
            {
                FSDK.TFacePosition facePosition = new FSDK.TFacePosition();
                FSDK.GetTrackerFacePosition(tracker, 0, IDs[i], ref facePosition);

                int x = facePosition.xc - (int)(facePosition.w * 0.6);
                int y = facePosition.yc - (int)(facePosition.w * 0.6);
                int w = (int)(facePosition.w * 1.2);

                Pen pen = new Pen(Color.FromArgb(115, 115, 115, 115), 3);

                RectInfo currentRectInfo = new RectInfo(x, y, w);

                currentRectInfo = ProccessRectInfo(currentRectInfo, IDs[i]);

                /*String name;
                int res = FSDK.GetAllNames(tracker, IDs[i], out name, 65536);

                if (FSDK.FSDKE_OK == res && name.Length > 0)
                {
                    StringFormat format = new StringFormat();
                    format.Alignment = StringAlignment.Center;

                    graphics.DrawString(name, new System.Drawing.Font("Arial", 16),
                    new System.Drawing.SolidBrush(System.Drawing.Color.LightGreen),
                    currentRectInfo.x + currentRectInfo.w / 2, currentRectInfo.y + currentRectInfo.w + 5, format);
                }*/
                pen = new Pen(Color.FromArgb(115, 115, 115, 115), 3);

                if (!CheckIfOpen())
                {
                    MouseOnRect(currentRectInfo, ref pen, i);
                }

                graphics.DrawRectangle(pen, currentRectInfo.x, currentRectInfo.y, currentRectInfo.w, currentRectInfo.w);
            }
        }
    }

    private Boolean CheckIfOpen()
    {
        FormCollection open = Application.OpenForms;

        foreach (Form form in open)
        {
            if (form.Name == Constants.MENU || form.Name == Constants.PROFILE)
                return true;
        }
        return false;
    }

    private RectInfo ProccessRectInfo(RectInfo currentRectInfo, long ID)
    {

        if (!rectInfoDictionary.ContainsKey(ID))
        {
            rectInfoDictionary.Add(ID, new Queue<RectInfo>());
        }

        rectInfoDictionary[ID].Enqueue(currentRectInfo);

        int length = rectInfoDictionary[ID].Count;

        

        int x = 0;
        int y = 0;
        int w = 0;
        
        foreach (RectInfo rectInfo in rectInfoDictionary[ID])
        {
            x += rectInfo.x;
            y += rectInfo.y;
            w += rectInfo.w;
        }

        x /= length;
        y /= length;
        w /= length;

        RectInfo newRectInfo = new RectInfo(x, y, w);

        if (length >= framesToSave)
        {
            rectInfoDictionary[ID].Dequeue();
        }

        return newRectInfo;
    }

    public void Stop()
    {
        DataController.Instance().SaveFaceData(tracker);
    }

    private void MouseOnRect(RectInfo rectInfo, ref Pen pen, int i)
    {
        int x = rectInfo.x + formX;
        int y = rectInfo.y + formY;
        int w = rectInfo.w;

        mouseX = Cursor.Position.X;
        mouseY = Cursor.Position.Y;

        if (mouseX >= x && mouseX <= x + w && mouseY >= y && mouseY <= y + w)
        {
            pen = new Pen(Color.FromArgb(115, 55, 55, 255), 3);
            if (Control.MouseButtons == MouseButtons.Left)
            {
                String name;
                FSDK.GetAllNames(tracker, IDs[i], out name, 65536);

                if (name != "")
                {
                    friendcognition.Profile profile = new friendcognition.Profile(Convert.ToInt32(name));
                    profile.Show();
                }
                else
                {
                    MessageBox.Show("User not registered","",MessageBoxButtons.OK);
                }
            }
        }
    }

    public bool Register(FSDK.CImage image, DataTable dt)
    {
        FSDK.FeedFrame(tracker, 0, image.ImageHandle, ref faceCount, out IDs, sizeof(long) * 256);
        Array.Resize(ref IDs, (int)faceCount);
        if (faceCount == 0)
        {
            MessageBox.Show(Constants.NO_FACE_ERROR);
            return false;
        }
        else if (faceCount > 1)
        {
            MessageBox.Show(Constants.MULTIPLE_FACES_ERROR);
            return false;
        }
        else
        {
            string id = Convert.ToString(dt.Rows[0]["Id"]);
            FSDK.SetName(tracker, IDs[0], id);
            return true;
        }
    }

}

