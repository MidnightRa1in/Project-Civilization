using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndustrialAuthority : Achievement
{
    public IndustrialAuthority():base()
    {
        
        buildingReq = new Dictionary<landBuilding, int>()
        {
            [landBuilding.Market] = 1,
            [landBuilding.Workshop] = 2,
            [landBuilding.MineralFacility] = 3,
            [landBuilding.Factory] = 2,
        };

        developReq = new Dictionary<landDevelopment, int>()
        {
            [landDevelopment.City] = 1,
            [landDevelopment.IndustrialArea] = 2,

        };

        resourceReq = new Dictionary<resource, int>()
        {
            [resource.mineral] = 200,
            [resource.labor] = 100,
            [resource.money] = 200,
            [resource.product] = 300,
        };
        statusReq = new Dictionary<landStatus, int>()
        {
            
        };

        developedLandsReq = 5;
        points = 100;
        achievementName = Achievements.IndustrialAuthority;
    }
}
