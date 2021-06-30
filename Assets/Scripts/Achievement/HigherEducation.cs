using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HigherEducation : Achievement
{
    public HigherEducation():base()
    {
        
        buildingReq = new Dictionary<landBuilding, int>()
        {
            [landBuilding.University] = 3,
        };

        developReq = new Dictionary<landDevelopment, int>()
        {
        };

        resourceReq = new Dictionary<resource, int>()
        {
            [resource.money] = 250,
            [resource.labor] = 300,
            [resource.product] = 250,
        };
        statusReq = new Dictionary<landStatus, int>()
        {
            
        };

        developedLandsReq = new int();
        achievementName = Achievements.HigherEducation;
    }
}
