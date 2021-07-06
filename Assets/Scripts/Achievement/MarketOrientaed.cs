using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarketOrientaed : Achievement
{
    public MarketOrientaed():base()
    {
        
        buildingReq = new Dictionary<landBuilding, int>()
        {
            [landBuilding.Market] = 5,
            [landBuilding.FinanceCenter] = 1,
        };

        developReq = new Dictionary<landDevelopment, int>()
        {
            [landDevelopment.Town] = 5,
        };

        resourceReq = new Dictionary<resource, int>()
        {
            [resource.money] = 300,
            [resource.material] = 200,
        };
        statusReq = new Dictionary<landStatus, int>()
        {
            
        };

        developedLandsReq = new int();
        points = 100;
        achievementName = Achievements.MarketOrientaed;
    }
}
