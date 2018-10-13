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
    private FaceRecognitionController faceRecognitionController;
    private int cameraHandle = 0;
    private FSDKCam.VideoFormatInfo[] formatList;

    public void InitializeCamera(PictureBox pictureBox)
    {
        faceRecognitionController = new FaceRecognitionController();
        currentPictureBox = pictureBox;

        if (FSDK.FSDKE_OK != FSDK.ActivateLibrary(Constants.LICENCE_KEY))
        {
            MessageBox.Show(Constants.ERROR_ACTIVATING_FACESDK, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Application.Exit();
        }

        FSDK.InitializeLibrary();
        FSDKCam.InitializeCapturing();

        string[] cameraList;
        int cameraCount;
        FSDKCam.GetCameraList(out cameraList, out cameraCount);

        if (cameraCount == 0)
        {
            MessageBox.Show(Constants.NO_CAMERA_ERROR, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Application.Exit();
        }

        cameraName = cameraList[0];
        FSDKCam.GetVideoFormatList(ref cameraName, out formatList, out cameraCount);

        int videoFormat = 0;
        currentPictureBox.Width = formatList[videoFormat].Width;
        currentPictureBox.Height = formatList[videoFormat].Height;
        }

    public void StartStreaming(bool recogniseFacialFeatures, Point location)
    {
        if (FSDKCam.OpenVideoCamera(ref cameraName, ref cameraHandle) != FSDK.FSDKE_OK)
        {
            MessageBox.Show(Constants.CAMERA_OPEN_ERROR, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Application.Exit();
        }

        FaceRecognitionController faceRecognitionController = new FaceRecognitionController();
        faceRecognitionController.Initialize(location);

        cameraWorking = true;

        while (cameraWorking)
        {
            Application.DoEvents();
            Int32 imageHandle = 0;
            FSDKCam.GrabFrame(cameraHandle, ref imageHandle);
            FSDK.CImage image = new FSDK.CImage(imageHandle);
            Image frameImage = image.ToCLRImage();

            faceRecognitionController.Update(image, frameImage, recogniseFacialFeatures);

            currentPictureBox.Image = frameImage;
            GC.Collect();
        }

        faceRecognitionController.Stop();

        FSDKCam.CloseVideoCamera(cameraHandle);
        FSDKCam.FinalizeCapturing();
    }

    public FSDKCam.VideoFormatInfo getVideoFormat()
    {
        return formatList[0];
    }

    public void StopStreaming()
    {
        cameraWorking = false;
    }

    public void ChangePictureBox(PictureBox pictureBox)
    {
        currentPictureBox = pictureBox;
    }

    public void SetName(string name)
    {
        Application.DoEvents();
        Int32 imageHandle = 0;
        FSDKCam.GrabFrame(cameraHandle, ref imageHandle);
        FSDK.CImage image = new FSDK.CImage(imageHandle);
        faceRecognitionController.SetName(name, image);
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

