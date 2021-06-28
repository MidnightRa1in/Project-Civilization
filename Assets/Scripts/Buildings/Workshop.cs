using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Workshop : Building
{

    public Workshop()
    {
        buildingName = landBuilding.Workshop;
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
            landStatus.Mountain
        };
        canNotBuildOn = new List<landDevelopment>()
        {
            landDevelopment.Undeveloped,
            landDevelopment.Village
        };
        resources = new Dictionary<resource, int>()
        {
            [resource.water] = -1,
            [resource.food] = -1,
            [resource.mineral] = -1,
            [resource.material] = -2,
            [resource.money] = 2,
            [resource.labor] = 0,
            [resource.product] = 3,

        };
        cost = new Dictionary<resource, int>()
        {
            [resource.water] = 15,
            [resource.food] = 10,
            [resource.mineral] = 4,
            [resource.material] = 10,
            [resource.money] = 10,
            [resource.labor] = 3,
            [resource.product] = 0,
        };

}
    public override bool CheckBuildingAllowance(Land land)
    {
        return base.CheckBuildingAllowance(land);
    }

}
