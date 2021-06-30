using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolyCity : Achievement
{
    public HolyCity():base()
    {
        
        buildingReq = new Dictionary<landBuilding, int>()
        {
            [landBuilding.ArtField] = 1,
            [landBuilding.ReligiousField] = 2,
        };

        developReq = new Dictionary<landDevelopment, int>()
        {
            [landDevelopment.Town] = 3,
            [landDevelopment.City] = 2,

        };

        resourceReq = new Dictionary<resource, int>()
        {
            [resource.labor] = 150,
        };
        statusReq = new Dictionary<landStatus, int>()
        {
            
        };

        developedLandsReq = 10;
        achievementName = Achievements.HolyCity;
    }
}
