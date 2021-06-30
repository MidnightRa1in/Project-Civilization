using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LowLand : Achievement
{
    public LowLand():base()
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
            [landStatus.Swamp] = 3,
        };

        developedLandsReq = new int();
        achievementName = Achievements.LowLand;
    }
}
