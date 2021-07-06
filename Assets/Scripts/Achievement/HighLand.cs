using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighLand : Achievement
{
    public HighLand():base()
    {
        
        buildingReq = new Dictionary<landBuilding, int>()
        {
        };

        developReq = new Dictionary<landDevelopment, int>()
        {
        };

        resourceReq = new Dictionary<resource, int>()
        {
        };
        statusReq = new Dictionary<landStatus, int>()
        {
            [landStatus.Plateau] = 8,
        };

        developedLandsReq = new int();
        points = 100;
        achievementName = Achievements.HighLand;
    }
}
