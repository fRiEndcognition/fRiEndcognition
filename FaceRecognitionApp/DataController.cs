using Luxand;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DataController
{

    private static DataController instance;

    private string trackerFile = "tracker.dat";

    public static DataController Instance()
    {
        if (instance == null)
        {
            instance = new DataController();
        }
        return instance;
    }

    public void LoadData(ref int tracker)
    {
        if (FSDK.LoadTrackerMemoryFromFile(ref tracker, trackerFile) != FSDK.FSDKE_OK)
        {
            FSDK.CreateTracker(ref tracker);
        }
    }

    public void SaveData(int tracker)
    {
        FSDK.SaveTrackerMemoryToFile(tracker, trackerFile);
        FSDK.FreeTracker(tracker);
    }
}

    

