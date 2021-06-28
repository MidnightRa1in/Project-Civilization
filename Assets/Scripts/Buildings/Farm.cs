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
            [resource.water] = 1,
            [resource.food] = 2,
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
