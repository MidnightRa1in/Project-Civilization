using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcademyPalace : Achievement
{
    public AcademyPalace():base()
    {
        
        buildingReq = new Dictionary<landBuilding, int>()
        {
            [landBuilding.University] = 3,
            [landBuilding.ArtField] = 1,
        };

        developReq = new Dictionary<landDevelopment, int>()
        {
            [landDevelopment.Town] = 3,
            [landDevelopment.City] = 3,

        };

        resourceReq = new Dictionary<resource, int>()
        {
            [resource.money] = 100,
            [resource.labor] = 100,
            [resource.product] = 100,
        };
        statusReq = new Dictionary<landStatus, int>()
        {
            
        };

        developedLandsReq = new int();
        achievementName = Achievements.AcademyPalace;
    }
}
