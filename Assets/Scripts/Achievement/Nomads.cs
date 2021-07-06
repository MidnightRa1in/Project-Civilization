using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nomads : Achievement
{
    public Nomads():base()
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
            [landStatus.Desert] = 2,
            [landStatus.Savanna] = 3,
            [landStatus.Mountain] = 1,
        };

        developedLandsReq = new int();
        points = 100;
        achievementName = Achievements.Nomads;
    }
}
