using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapitalOfArt : Achievement
{
    public CapitalOfArt() : base()
    {

        buildingReq = new Dictionary<landBuilding, int>()
        {
            [landBuilding.ArtField] = 2,
            [landBuilding.University] = 1,
        };

        developReq = new Dictionary<landDevelopment, int>()
        {
            [landDevelopment.Town] = 3,
            [landDevelopment.City] = 2,
        };

        resourceReq = new Dictionary<resource, int>()
        {
            [resource.material] = 200,
            [resource.product] = 200,
        };
        statusReq = new Dictionary<landStatus, int>()
        {

        };

        developedLandsReq = new int();
        achievementName = Achievements.CapitalOfArt;
    }
}
