using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinanceDistrict : Achievement
{
    public FinanceDistrict() : base()
    {

        buildingReq = new Dictionary<landBuilding, int>()
        {
            [landBuilding.Market] = 3,
            [landBuilding.FinanceCenter] = 3,
        };

        developReq = new Dictionary<landDevelopment, int>()
        {
            [landDevelopment.City] = 2,
        };

        resourceReq = new Dictionary<resource, int>()
        {
            [resource.money] = 250,
            [resource.product] = 150,
        };
        statusReq = new Dictionary<landStatus, int>()
        {

        };

        developedLandsReq = 5;
        achievementName = Achievements.FinanceDistrict;
    }
}
