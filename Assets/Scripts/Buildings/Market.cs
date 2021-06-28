using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Market : Building
{

    public Market()
    {
        buildingName = landBuilding.Market;
        canBuildOn = new List<landStatus>()
        {
            landStatus.Desert,
            landStatus.Lake,
            landStatus.Riverside,
            landStatus.Plateau,
            landStatus.Plain,
            landStatus.Island,
            landStatus.Savanna
        };
        canNotBuildOn = new List<landDevelopment>()
        {
            landDevelopment.Undeveloped,
            landDevelopment.Village,
        };
        resources = new Dictionary<resource, int>()
        {
            [resource.water] = -1,
            [resource.food] = -1,
            [resource.mineral] = 0,
            [resource.material] = -1,
            [resource.money] = 4,
            [resource.labor] = 0,
            [resource.product] = 0,

        };
        cost = new Dictionary<resource, int>()
        {
            [resource.water] = 10,
            [resource.food] = 10,
            [resource.mineral] = 5,
            [resource.material] = 15,
            [resource.money] = 5,
            [resource.labor] = 10,
            [resource.product] = 0,
        };
    }
    public override bool CheckBuildingAllowance(Land land)
    {
        return base.CheckBuildingAllowance(land);
    }
}
