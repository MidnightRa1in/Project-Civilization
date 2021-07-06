using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtmosphereOfArt : Achievement
{
    public AtmosphereOfArt():base()
    {
        
        buildingReq = new Dictionary<landBuilding, int>()
        {
            [landBuilding.ArtField] = 3,
        };

        developReq = new Dictionary<landDevelopment, int>()
        {
        };

        resourceReq = new Dictionary<resource, int>()
        {
            [resource.product] = 200,
            [resource.money] = 250,
        };
        statusReq = new Dictionary<landStatus, int>()
        {
            
        };

        developedLandsReq = new int();
        points = 100;
        achievementName = Achievements.AtmosphereOfArt;
    }
}
