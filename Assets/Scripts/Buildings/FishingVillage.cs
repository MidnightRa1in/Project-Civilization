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
            [resource.material] = 0,
            [resource.money] = 1,
            [resource.labor] = 1,
            [resource.product] = 0,

        };
        cost = new Dictionary<resource, int>()
        {
            [resource.water] = 6,
            [resource.food] = 7,
            [resource.mineral] = 0,
            [resource.material] = 4,
            [resource.money] = 0,
            [resource.labor] = 1,
            [resource.product] = 0,
        };
    }
    public override bool CheckBuildingAllowance(Land land)
    {
        return base.CheckBuildingAllowance(land);
    }
}
