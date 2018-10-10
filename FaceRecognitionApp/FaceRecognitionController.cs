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
    public struct rectInfo
    {
        public int x;
        public int y;
        public int w;
    }

    public long[] IDs;
    public long faceCount = 0;
    public int tracker = 0;
    private string trackerFile = "tracker.dat";
    private string username;
    private int mouseX = 0;
    private int mouseY = 0;

    private Dictionary<long, rectInfo[]> rectInfoDictionary;

    public void Initialize()
    {
        tracker = 0;
        if (FSDK.LoadTrackerMemoryFromFile(ref tracker, trackerFile) != FSDK.FSDKE_OK)
        {
            FSDK.CreateTracker(ref tracker);
        }
        int err = 0;
        FSDK.SetTrackerMultipleParameters(tracker, "HandleArbitraryRotations=false; DetermineFaceRotationAngle=false; InternalResizeWidth=300; FaceDetectionThreshold=5;", ref err);
    }

    public void DoLoop(FSDK.CImage image, Image frameImage, bool recogniseFacialFeatures)
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

            Pen pen = new Pen(Color.FromArgb(115, 115, 115, 115), 3);

            if (recogniseFacialFeatures == true)
            {
                FSDK.TPoint[] facialFeatures;
                FSDK.GetTrackerFacialFeatures(tracker, 0, IDs[i], out facialFeatures);

                foreach (FSDK.TPoint point in facialFeatures)
                    graphics.FillEllipse(Brushes.Blue, point.x, point.y, 5, 5);
            }
            else
            {
                String name;
                int res = FSDK.GetAllNames(tracker, IDs[i], out name, 65536);

                if (FSDK.FSDKE_OK == res && name.Length > 0)
                {
                    pen = new Pen(Color.FromArgb(115, 55, 55, 255), 3);
                    StringFormat format = new StringFormat();
                    format.Alignment = StringAlignment.Center;

                    graphics.DrawString(name, new System.Drawing.Font("Arial", 16),
                        new System.Drawing.SolidBrush(System.Drawing.Color.Black),
                        facePosition.xc, y + w + 5, format);
                }

                mouseX = Cursor.Position.X;
                mouseY = Cursor.Position.Y;

                if (mouseX >= x && mouseX <= x + w && mouseY >= y && mouseY <= y + w)
                {
                    pen = new Pen(Color.Blue,3);
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

            graphics.DrawRectangle(pen, x, y, w, w);
        }
    }

    public void SaveData()
    {
        FSDK.SaveTrackerMemoryToFile(tracker, trackerFile);
        FSDK.FreeTracker(tracker);
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

    public void SetName(string name, FSDK.CImage image)
    {
        FSDK.FeedFrame(tracker, 0, image.ImageHandle, ref faceCount, out IDs, sizeof(long) * 256);
        Array.Resize(ref IDs, (int)faceCount);
        if (FSDK.FSDKE_OK == FSDK.LockID(tracker, IDs[0]))
        {
            FSDK.SetName(tracker, IDs[0], name);
            FSDK.UnlockID(tracker, IDs[0]);
        }
    }

}

