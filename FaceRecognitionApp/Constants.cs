using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Constants
{
    public const string ERROR_ACTIVATING_FACESDK = "Error activating FaceSDK - please enter license key";
    public const string NO_CAMERA_ERROR = "No camera found";
    public const string CAMERA_OPEN_ERROR = "Unable to open camera";

    // buttons

    public const string START_BUTTON = "start_button";
    public const string SUBMIT_BUTTON = "submit_button";
    public const string EXIT_BUTTON = "exit_button";

    //Don't forget to add the license file to bin/debug----------------------->
    public static readonly string LICENCE_KEY= System.IO.File.ReadAllText(@".\LICENSE.txt");

}


