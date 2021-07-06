using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdvancedInIndustry : Achievement
{
    public AdvancedInIndustry():base()
    {
        
        buildingReq = new Dictionary<landBuilding, int>()
        {
        };

        developReq = new Dictionary<landDevelopment, int>()
        {
        };

        resourceReq = new Dictionary<resource, int>()
        {
            [resource.product] = 450,
            [resource.money] = 350,
            [resource.labor] = 250,
        };
        statusReq = new Dictionary<landStatus, int>()
        {
            
        };

        developedLandsReq = 8;
        points = 100;
        achievementName = Achievements.AdvancedInIndustry;
    }
}
