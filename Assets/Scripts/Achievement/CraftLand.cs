using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftLand : Achievement
{
    public CraftLand():base()
    {
        
        buildingReq = new Dictionary<landBuilding, int>()
        {
            [landBuilding.Workshop] = 4,
            [landBuilding.Market] = 2,
            [landBuilding.MaterialFacility] = 2,
        };

        developReq = new Dictionary<landDevelopment, int>()
        {
            [landDevelopment.Town] = 3,
        };

        resourceReq = new Dictionary<resource, int>()
        {
            [resource.product] = 250,
            [resource.labor] = 200,
            [resource.material] = 200,
            [resource.money] = 250,
        };
        statusReq = new Dictionary<landStatus, int>()
        {
            
        };

        developedLandsReq = new int();
        achievementName = Achievements.CraftLand;
    }
}
