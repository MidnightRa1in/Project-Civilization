using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TradeArea : Achievement
{
    public TradeArea():base()
    {
        
        buildingReq = new Dictionary<landBuilding, int>()
        {
            [landBuilding.Market] = 3,
            [landBuilding.Harbor] = 2,

        };

        developReq = new Dictionary<landDevelopment, int>()
        {
            [landDevelopment.Town] = 2,
            [landDevelopment.City] = 2,

        };

        resourceReq = new Dictionary<resource, int>()
        {
            [resource.money] = 300,
            [resource.product] = 200,
        };
        statusReq = new Dictionary<landStatus, int>()
        {
            
        };

        developedLandsReq = 5;
        points = 100;
        achievementName = Achievements.TradeArea;
    }
}
