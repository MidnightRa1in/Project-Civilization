using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighPopulation : Achievement
{
    public HighPopulation():base()
    {
        
        buildingReq = new Dictionary<landBuilding, int>()
        {

        };

        developReq = new Dictionary<landDevelopment, int>()
        {
            [landDevelopment.Town] = 3,
            [landDevelopment.City] = 2,
        };

        resourceReq = new Dictionary<resource, int>()
        {
            [resource.labor] = 400,
            [resource.food] = 300,
            [resource.water] = 300,
        };
        statusReq = new Dictionary<landStatus, int>()
        {
            
        };

        developedLandsReq = new int();
        points = 100;
        achievementName = Achievements.HighPopulation;
    }
}
