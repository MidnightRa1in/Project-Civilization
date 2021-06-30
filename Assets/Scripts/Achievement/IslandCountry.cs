using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IslandCountry : Achievement
{
    public IslandCountry():base()
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
            [landStatus.Island] = 6,
        };

        developedLandsReq = new int();
        achievementName = Achievements.IslandCountry;
    }
}
