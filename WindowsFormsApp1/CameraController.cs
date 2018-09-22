using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Luxand;

class CameraController
{

    private static CameraController instance;

    private string cameraName;

    private PictureBox currentPictureBox;

    public bool cameraWorking = true;

    private CameraController()
    {
    }

    public void InitializeCamera(PictureBox pictureBox)
    {
        currentPictureBox = pictureBox;    

        if (FSDK.FSDKE_OK != FSDK.ActivateLibrary("colDhMxd3noCHRGBUPPlRrUW2NPTos6UGG6O8WkiZxzqS7R6e1KhzsJztksKgl1iWdePMcg9ransUedZAX7LAKegwtXLVT7FLXWH5/suefXLR6Ujl/CH5Yf2Ur+E06hTR93X8ODBQdhjQH4RBZB1bCBalylvewvpusFjHQkgTZk="))
        {
            MessageBox.Show("Error activating FaceSDK - please enter license key", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Application.Exit();
        }

        FSDK.InitializeLibrary();
        FSDKCam.InitializeCapturing();

        string[] cameraList;
        int cameraCount;
        FSDKCam.GetCameraList(out cameraList, out cameraCount);

        if (cameraCount == 0)
        {
            MessageBox.Show("No camera found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Application.Exit();
        }

        cameraName = cameraList[0];
        FSDKCam.VideoFormatInfo[] formatList;
        FSDKCam.GetVideoFormatList(ref cameraName, out formatList, out cameraCount);

        int videoFormat = 0;
        currentPictureBox.Width = formatList[videoFormat].Width;
        currentPictureBox.Height = formatList[videoFormat].Height;
        //this.Width = formatList[videoFormat].Width + 50;
        //this.Height = formatList[videoFormat].Height + 100;
    }

    public void StartStreaming()
    {
        int cameraHandle = 0;
        if (FSDKCam.OpenVideoCamera(ref cameraName, ref cameraHandle) != FSDK.FSDKE_OK)
        {
            MessageBox.Show("Error opening the camera", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Application.Exit();
        }

        cameraWorking = true;

        while (cameraWorking)
        {
            Application.DoEvents();
            Int32 imageHandle = 0;
            FSDKCam.GrabFrame(cameraHandle, ref imageHandle);
            FSDK.CImage image = new FSDK.CImage(imageHandle);
            Image frameImage = image.ToCLRImage();
            currentPictureBox.Image = frameImage;
        }

        FSDKCam.CloseVideoCamera(cameraHandle);
        FSDKCam.FinalizeCapturing();
    }

    public void StopStreaming()
    {
        cameraWorking = false;
    }

    public void ChangePictureBox(PictureBox pictureBox)
    {
        currentPictureBox = pictureBox;
    }

    public static CameraController Instance()
    {
        if (instance == null)
        {
            instance = new CameraController();
        }
        return instance;
    }
}

