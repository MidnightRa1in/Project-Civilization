using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrasslandCommunity : Achievement
{
    public GrasslandCommunity():base()
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
            [landStatus.Savanna] = 5,
        };

        developedLandsReq = new int();
        points = 100;
        achievementName = Achievements.GrasslandCommunity;
    }
}
