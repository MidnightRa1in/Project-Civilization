using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateOfHell : Achievement
{
    public GateOfHell():base()
    {
        
        buildingReq = new Dictionary<landBuilding, int>()
        {
        };

        developReq = new Dictionary<landDevelopment, int>()
        {
        };

        resourceReq = new Dictionary<resource, int>()
        {
        };
        statusReq = new Dictionary<landStatus, int>()
        {
            [landStatus.Volcano] = 1,
        };

        developedLandsReq = new int();
        points = 100;
        achievementName = Achievements.GateOfHell;
    }
}
