using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manufacturer : Achievement
{
    public Manufacturer():base()
    {
        
        buildingReq = new Dictionary<landBuilding, int>()
        {
            [landBuilding.MineralFacility] = 1,
            [landBuilding.Factory] = 1,
            [landBuilding.MaterialFacility] = 5,
            [landBuilding.Market] = 3,
        };

        developReq = new Dictionary<landDevelopment, int>()
        {
            [landDevelopment.Town] = 5,     
        };

        resourceReq = new Dictionary<resource, int>()
        {
            [resource.material] = 150,
            [resource.labor] = 50,
            [resource.money] = 150,
            [resource.product] = 200,
        };
        statusReq = new Dictionary<landStatus, int>()
        {
            
        };

        developedLandsReq = 7;
        points = 200;
        achievementName = Achievements.Manufacturer;
    }
}
