using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Farm : Building
{
    public Farm()
    {
        buildingName = landBuilding.Farm;
        canBuildOn = new List<landStatus>()
        {
            landStatus.Volcano,
            landStatus.Desert,
            landStatus.Forest,
            landStatus.Lake,
            landStatus.Riverside,
            landStatus.Plateau,
            landStatus.Plain,
            landStatus.Island,
            landStatus.Swamp,
            landStatus.Savanna,
            landStatus.Mountain
        };
        canNotBuildOn = new List<landDevelopment>()
        {
            landDevelopment.Undeveloped,
        };
        resources = new Dictionary<resource, int>()
        {
            [resource.water] = 0,
            [resource.food] = 2,
            [resource.mineral] = 0,
            [resource.material] = 0,
            [resource.money] = 1,
            [resource.labor] = 1,
            [resource.product] = 0,

        };
        cost = new Dictionary<resource, int>()
        {
            [resource.water] = 8,
            [resource.food] = 8,
            [resource.mineral] = 0,
            [resource.material] = 6,
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
