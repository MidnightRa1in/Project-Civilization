using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OceanCulture : Achievement
{
    public OceanCulture():base()
    {
        
        buildingReq = new Dictionary<landBuilding, int>()
        {
            [landBuilding.FishingVillage] = 5,
            [landBuilding.Harbor] = 1,
            [landBuilding.ArtField] = 1,
        };

        developReq = new Dictionary<landDevelopment, int>()
        {
            [landDevelopment.Town] = 3,
        };

        resourceReq = new Dictionary<resource, int>()
        {
            [resource.water] = 200,
        };
        statusReq = new Dictionary<landStatus, int>()
        {
            
        };

        developedLandsReq = new int();
        points = 100;
        achievementName = Achievements.OceanCulture;
    }
}
