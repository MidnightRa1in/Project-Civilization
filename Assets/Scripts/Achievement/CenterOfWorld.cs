using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenterOfWorld : Achievement
{
    public CenterOfWorld():base()
    {
        
        buildingReq = new Dictionary<landBuilding, int>()
        {
            [landBuilding.University] = 1,
            [landBuilding.Factory] = 1,
            [landBuilding.ArtField] = 1,
            [landBuilding.ReligiousField] = 1,
            [landBuilding.FinanceCenter] = 1

        };

        developReq = new Dictionary<landDevelopment, int>()
        {
            [landDevelopment.Town] = 5,
            [landDevelopment.City] = 2,
            [landDevelopment.IndustrialArea] = 1,

        };

        resourceReq = new Dictionary<resource, int>()
        {
            [resource.money] = 100,
            [resource.labor] = 50,
            [resource.product] = 80,
        };
        statusReq = new Dictionary<landStatus, int>()
        {
            
        };

        developedLandsReq = 10;
        achievementName = Achievements.CenterOfWorld;
    }


}
