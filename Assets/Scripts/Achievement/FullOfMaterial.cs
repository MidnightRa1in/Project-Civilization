using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullOfMaterial : Achievement
{
    public FullOfMaterial():base()
    {
        
        buildingReq = new Dictionary<landBuilding, int>()
        {
        };

        developReq = new Dictionary<landDevelopment, int>()
        {
        };

        resourceReq = new Dictionary<resource, int>()
        {
            [resource.mineral] = 300,
            [resource.material] = 450,
        };
        statusReq = new Dictionary<landStatus, int>()
        {
            
        };

        developedLandsReq = new int();
        points = 100;
        achievementName = Achievements.FullOfMaterial;
    }
}
