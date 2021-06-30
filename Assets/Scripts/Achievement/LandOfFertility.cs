using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LandOfFertility : Achievement
{
    public LandOfFertility():base()
    {
        
        buildingReq = new Dictionary<landBuilding, int>()
        {
        };

        developReq = new Dictionary<landDevelopment, int>()
        {
        };

        resourceReq = new Dictionary<resource, int>()
        {
            [resource.food] = 400,
            [resource.water] = 400,
            [resource.material] = 300,
        };
        statusReq = new Dictionary<landStatus, int>()
        {
            
        };

        developedLandsReq = 8;
        achievementName = Achievements.LandOfFertility;
    }
}
