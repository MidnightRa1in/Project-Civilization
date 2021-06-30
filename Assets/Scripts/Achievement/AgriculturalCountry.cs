using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgriculturalCountry : Achievement
{
    public AgriculturalCountry():base()
    {
        
        buildingReq = new Dictionary<landBuilding, int>()
        {
            [landBuilding.Farm] = 6,
            [landBuilding.MaterialFacility] = 3,
            [landBuilding.Market] = 2,
        };

        developReq = new Dictionary<landDevelopment, int>()
        {
            [landDevelopment.Village] = 4,
            [landDevelopment.Town] = 2,
        };

        resourceReq = new Dictionary<resource, int>()
        {
            [resource.food] = 250,
        };
        statusReq = new Dictionary<landStatus, int>()
        {
            
        };

        developedLandsReq = new int();
        achievementName = Achievements.AgriculturalCountry;
    }
}
