using Luxand;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

class DataController
{

    private Dictionary<string, string> loginInfo;

    private static DataController instance;

    private string trackerFile = "tracker.dat";

    public static DataController Instance()
    {
        if (instance == null)
        {
            instance = new DataController();
            instance.InitializeLoginInfo();
        }
        return instance;
    }

    private void InitializeLoginInfo()
    {
        loginInfo = new Dictionary<string, string>();
    }

    public void LoadFaceData(ref int tracker)
    {
        if (FSDK.LoadTrackerMemoryFromFile(ref tracker, trackerFile) != FSDK.FSDKE_OK)
        {
            FSDK.CreateTracker(ref tracker);
        }
    }

    public void SaveFaceData(int tracker)
    {
        FSDK.SaveTrackerMemoryToFile(tracker, trackerFile);
        FSDK.FreeTracker(tracker);
    }

    public bool Login(string email, string password)
    {
        if (!loginInfo.ContainsKey(email))
        {
            MessageBox.Show(Constants.WRONG_EMAIL);
            return false;
        }

        if (loginInfo[email].Equals(password))
        {
            return true;
        }

        MessageBox.Show(Constants.WRONG_PASSWORD);
        return false;

    }

    public bool Register(string name, string surname, string email, string password)
    {
        if (!ValidateEmail(email))
        {
            MessageBox.Show(Constants.WRONG_EMAIL);
            return false;
        }

        if (loginInfo.ContainsKey(email))
        {
            MessageBox.Show(Constants.EMAIL_ALREADY_EXISTS);
            return false;
        }

        if (!ValidateStringOnlyLetters(name))
        {
            MessageBox.Show(Constants.INVALID_NAME);
            return false;
        }
        if (!ValidateStringOnlyLetters(name))
        {
            MessageBox.Show(Constants.INVALID_SURNAME);
            return false;
        }

        loginInfo.Add(email, password);

        return true;

    }

    private bool ValidateEmail(string email)
    {
        if (Regex.IsMatch(email, Constants.REGEX_EMAIL))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private bool ValidateStringOnlyLetters(string input)
    {
        if (Regex.IsMatch(input, Constants.REGEX_ONLY_LETTERS))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

    

