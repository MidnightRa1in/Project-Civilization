using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OriginOfCivilization : Achievement
{
    public OriginOfCivilization():base()
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
            [landStatus.Riverside] = 5,
            [landStatus.Plain] = 2,
        };

        developedLandsReq = new int();
        points = 200;
        achievementName = Achievements.OriginOfCivilization;
    }
}
