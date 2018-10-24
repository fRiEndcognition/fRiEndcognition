using Luxand;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

public class DataController
{

    private Dictionary<string, string> loginInfo;

    private static DataController instance;

    private string trackerFile = "tracker.dat";

    private int id;

    public static DataController Instance()
    {
        if (instance == null)
        {
            instance = new DataController();
            instance.InitializeLoginInfo();
        }
        return instance;
    }

    public DataTable ExecSP(string spName, List<SqlParameter> sqlParams = null) 
    {
        string connectionString = Constants.DATABASE;
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

    public int getId()
    {
        return id;
    }

    public void setId(int id)
    {
        this.id = id;
    }

    public byte[] ConvertImageToByteArray(Image image)
    {
        using (var ms = new MemoryStream())
        {
            image.Save(ms, ImageFormat.Jpeg);
            return ms.ToArray();
        }
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

    public bool ValidateEmail(string email)
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

    public bool ValidateStringOnlyLetters(string input)
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

    

