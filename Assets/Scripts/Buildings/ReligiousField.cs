using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReligiousField : Building
{

    public ReligiousField()
    {
        buildingName = landBuilding.ReligiousField;
        canBuildOn = new List<landStatus>()
        {
            landStatus.Desert,
            landStatus.Forest,
            landStatus.Lake,
            landStatus.Riverside,
            landStatus.Plateau,
            landStatus.Plain,
            landStatus.Island,
            landStatus.Swamp,
            landStatus.Mountain
         };
        canNotBuildOn = new List<landDevelopment>()
        {
            landDevelopment.Undeveloped,
            landDevelopment.IndustrialArea
        };
        turnLimit = 10;
        resources = new Dictionary<resource, int>()
        {
            [resource.water] = 1,
            [resource.food] = 1,
            [resource.mineral] = -1,
            [resource.material] = 0,
            [resource.money] = -2,
            [resource.labor] = 0,
            [resource.product] = -1,

        };
        cost = new Dictionary<resource, int>()
        {
            [resource.water] = 40,
            [resource.food] = 60,
            [resource.mineral] = 20,
            [resource.material] = 20,
            [resource.money] = 30,
            [resource.labor] = 15,
            [resource.product] = 15,
        };
    }
    public override bool CheckBuildingAllowance(Land land)
    {
        return base.CheckBuildingAllowance(land);
    }
}
