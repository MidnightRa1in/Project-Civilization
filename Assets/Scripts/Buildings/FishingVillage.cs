using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishingVillage : Building
{

    public FishingVillage()
    {
        buildingName = landBuilding.FishingVillage;
        canBuildOn = new List<landStatus>()
        {
            landStatus.Lake,
            landStatus.Riverside,
            landStatus.Seashore,
            landStatus.Island,
        };
        canNotBuildOn = new List<landDevelopment>()
        {
            landDevelopment.Undeveloped,
        };
        resources = new Dictionary<resource, int>()
        {
            [resource.water] = 1,
            [resource.food] = 1,
            [resource.mineral] = 0,
            [resource.material] = -1,
            [resource.money] = 0,
            [resource.labor] = 1,
            [resource.product] = 1,

        };
        cost = new Dictionary<resource, int>()
        {
            [resource.water] = 5,
            [resource.food] = 5,
            [resource.mineral] = 0,
            [resource.material] = 5,
            [resource.money] = 0,
            [resource.labor] = 2,
            [resource.product] = 0,
        };
    }
    public override bool CheckBuildingAllowance(Land land)
    {
        return base.CheckBuildingAllowance(land);
    }
}
