using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CityStates : Achievement
{
    public CityStates():base()
    {
        
        buildingReq = new Dictionary<landBuilding, int>()
        {

        };

        developReq = new Dictionary<landDevelopment, int>()
        {
            [landDevelopment.Town] = 3,
            [landDevelopment.City] = 5,
        };

        resourceReq = new Dictionary<resource, int>()
        {
            [resource.labor] = 200,
            [resource.material] = 150,
        };
        statusReq = new Dictionary<landStatus, int>()
        {
            
        };

        developedLandsReq = 10;
        points = 100;
        achievementName = Achievements.CityStates;
    }
}
