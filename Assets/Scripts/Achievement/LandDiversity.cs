using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LandDiversity : Achievement
{
    public LandDiversity():base()
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
            [landStatus.Plateau] = 1,
            [landStatus.Mountain] = 1,
            [landStatus.Lake] = 1,
            [landStatus.Forest] = 1,
            [landStatus.Desert] = 1,
            [landStatus.Seashore] = 1,
            [landStatus.Savanna] = 1,
            [landStatus.Swamp] = 1,
        };

        developedLandsReq = new int();
        achievementName = Achievements.LandDiversity;
    }
}
