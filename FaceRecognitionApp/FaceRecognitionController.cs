using Luxand;
using System;
using System.Collections.Generic;
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
    private string trackerFile = "tracker.dat";
    private string username;
    private int mouseX = 0;
    private int mouseY = 0;

    private int framesToSave = 10;

    private Dictionary<long, Queue<RectInfo>> rectInfoDictionary;

    public void Initialize()
    {
        tracker = 0;
        if (FSDK.LoadTrackerMemoryFromFile(ref tracker, trackerFile) != FSDK.FSDKE_OK)
        {
            FSDK.CreateTracker(ref tracker);
        }
        int err = 0;
        FSDK.SetTrackerMultipleParameters(tracker, "HandleArbitraryRotations=false; DetermineFaceRotationAngle=false; InternalResizeWidth=300; FaceDetectionThreshold=5;", ref err);

        rectInfoDictionary = new Dictionary<long, Queue<RectInfo>>();
    }

    public void DoLoop(FSDK.CImage image, Image frameImage)
    {
        FSDK.FeedFrame(tracker, 0, image.ImageHandle, ref faceCount, out IDs, sizeof(long) * 256);
        Array.Resize(ref IDs, (int)faceCount);

        //Drawing rectangles
        Graphics graphics = Graphics.FromImage(frameImage);

        for (int i = 0; i < IDs.Length; ++i)
        {
            FSDK.TFacePosition facePosition = new FSDK.TFacePosition();
            FSDK.GetTrackerFacePosition(tracker, 0, IDs[i], ref facePosition);

            int x = facePosition.xc - (int)(facePosition.w * 0.6);
            int y = facePosition.yc - (int)(facePosition.w * 0.6);
            int w = (int)(facePosition.w * 1.2);

            RectInfo currentRectInfo = new RectInfo(x, y, w);

            currentRectInfo = ProccessRectInfo(currentRectInfo, IDs[i]);

            String name;
            int res = FSDK.GetAllNames(tracker, IDs[i], out name, 65536);

            if (FSDK.FSDKE_OK == res && name.Length > 0)
            {
                StringFormat format = new StringFormat();
                format.Alignment = StringAlignment.Center;

                graphics.DrawString(name, new System.Drawing.Font("Arial", 16),
                    new System.Drawing.SolidBrush(System.Drawing.Color.LightGreen),
                    currentRectInfo.x + currentRectInfo.w / 2, currentRectInfo.y + currentRectInfo.w + 5, format);
            }

            

            Pen pen = new Pen(Color.FromArgb(115, 115, 115, 115), 3);

            MouseOnRect(currentRectInfo, ref pen, i);

            graphics.DrawRectangle(pen, currentRectInfo.x, currentRectInfo.y, currentRectInfo.w, currentRectInfo.w);
        }
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

    public void SaveData()
    {
        FSDK.SaveTrackerMemoryToFile(tracker, trackerFile);
        FSDK.FreeTracker(tracker);
    }

    private void MouseOnRect(RectInfo rectInfo, ref Pen pen, int i)
    {
        int x = rectInfo.x;
        int y = rectInfo.y;
        int w = rectInfo.w;

        mouseX = Cursor.Position.X;
        mouseY = Cursor.Position.Y;

        if (mouseX >= x && mouseX <= x + w && mouseY >= y && mouseY <= y + w)
        {
            pen = new Pen(Color.FromArgb(115, 55, 55, 255), 3);
            if (Control.MouseButtons == MouseButtons.Left)
            {
                if (FSDK.FSDKE_OK == FSDK.LockID(tracker, IDs[i]))
                {
                    friendcognition.NameInput nameInput = new friendcognition.NameInput();
                    if (nameInput.ShowDialog() == DialogResult.OK)
                    {
                        username = nameInput.username;
                        if (username == null || username.Length <= 0)
                        {
                            FSDK.SetName(tracker, IDs[i], "");
                            FSDK.PurgeID(tracker, IDs[i]);
                        }
                        else
                        {
                            FSDK.SetName(tracker, IDs[i], username);
                        }
                        FSDK.UnlockID(tracker, IDs[i]);
                    }
                }
            }
        }
    }

    private void DrawRectangles(Graphics graphics)
    {
        for (int i = 0; i < IDs.Length; ++i)
        {
            FSDK.TFacePosition facePosition = new FSDK.TFacePosition();
            FSDK.GetTrackerFacePosition(tracker, 0, IDs[i], ref facePosition);

            Console.WriteLine(IDs[i]);

            int x = facePosition.xc - (int)(facePosition.w * 0.6);
            int y = facePosition.yc - (int)(facePosition.w * 0.6);
            int w = (int)(facePosition.w * 1.2);
            Pen pen = new Pen(Color.FromArgb(255, 0, 0, 115), 3);
            graphics.DrawRectangle(pen, x, y, w, w);
        }
    }

}

