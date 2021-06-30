using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlourishingReligion : Achievement
{
    public FlourishingReligion():base()
    {
        
        buildingReq = new Dictionary<landBuilding, int>()
        {
            [landBuilding.ReligiousField] = 3,
        };

        developReq = new Dictionary<landDevelopment, int>()
        {
        };

        resourceReq = new Dictionary<resource, int>()
        {
            [resource.money] = 350,
        };
        statusReq = new Dictionary<landStatus, int>()
        {
            
        };

        developedLandsReq = new int();
        achievementName = Achievements.FlourishingReligion;
    }
}
