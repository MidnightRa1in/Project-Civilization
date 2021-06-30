using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesertClan : Achievement
{
    public DesertClan():base()
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
            [landStatus.Desert] = 4,
        };

        developedLandsReq = new int();
        achievementName = Achievements.DesertClan;
    }
}
