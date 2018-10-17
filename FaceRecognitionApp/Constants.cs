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
    public const string NO_FACE_ERROR = "Can't detect your face!";
    public const string MULTIPLE_FACES_ERROR = "Make sure there is only one face on the screen!";
    public const string REGISTER = "Register";

    public const string WRONG_EMAIL = "Wrong email";
    public const string WRONG_PASSWORD = "Wrong password";

    public const string INVALID_NAME = "Invalind name";
    public const string INVALID_SURNAME = "Invalid surname";

    public const string EMAIL_ALREADY_EXISTS = "Such email already exists";

    public const string MENU = "Menu";
    public const string PROFILE = "Profile";
    // Regex

    public const string REGEX_ONLY_LETTERS = @"^[a-zA-Z]+$";
    public const string REGEX_EMAIL = @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
    // buttons

    public const string PHOTO_BUTTON = "photo_button";
    public const string START_BUTTON = "start_button";
    public const string SUBMIT_BUTTON = "submit_button";
    public const string EXIT_BUTTON = "exit_button";

    //Don't forget to add the license file to bin/debug----------------------->
    public static readonly string LICENCE_KEY= System.IO.File.ReadAllText(@".\LICENSE.txt");

}


