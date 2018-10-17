﻿using Luxand;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

    public static DataTable ExecSP(string spName, List<SqlParameter> sqlParams = null) 
    {
        string connectionString = "Server=tcp:friendcognition.database.windows.net,1433;Initial Catalog=Database;Persist Security Info=False;User ID=gravus;Password=Saldytuvas1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        SqlConnection cnn = new SqlConnection();
        DataTable dt = new DataTable();

        try
        {
            cnn = new SqlConnection(connectionString);
            cnn.Open();

            SqlCommand cmd = new SqlCommand(spName, cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddRange(sqlParams.ToArray());

            SqlCommand command = cnn.CreateCommand();
            SqlDataReader dr = cmd.ExecuteReader();

            dt.Load(dr);
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            cnn.Close();
        }
        return dt;
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

    

