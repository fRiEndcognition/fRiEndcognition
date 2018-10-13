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
            MessageBox.Show("Wrong email!");
            return false;
        }

        if (loginInfo[email].Equals(password))
        {
            return true;
        }

        MessageBox.Show("Wrong password!");
        return false;

    }

    public bool Register(string name, string surname, string email, string password)
    {
        if (!ValidateEmail(email))
        {
            MessageBox.Show("Wrong email!");
            return false;
        }

        if (loginInfo.ContainsKey(email))
        {
            MessageBox.Show("Such email already exists!");
            return false;
        }

        if (!ValidateString(name))
        {
            MessageBox.Show("Invalid name!");
            return false;
        }
        if (!ValidateString(name))
        {
            MessageBox.Show("Invalid surname!");
            return false;
        }

        loginInfo.Add(email, password);

        return true;

    }

    private bool ValidateEmail(string email)
    {
        string pattern = @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
        if (Regex.IsMatch(email, pattern))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private bool ValidateString(string input)
    {
        string pattern = @"^[a-zA-Z]+$";
        if (Regex.IsMatch(input, pattern))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

    

