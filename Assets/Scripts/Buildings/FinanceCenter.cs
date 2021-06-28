using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinanceCenter : Building
{
    public FinanceCenter()
    {
        buildingName = landBuilding.FinanceCenter;
        canBuildOn = new List<landStatus>()
        {
            landStatus.Lake,
            landStatus.Riverside,
            landStatus.Plateau,
            landStatus.Plain,
            landStatus.Savanna,
            landStatus.Seashore
        };
        canNotBuildOn = new List<landDevelopment>()
        {
            landDevelopment.Undeveloped,
            landDevelopment.Village,
            landDevelopment.Town,
        };
        turnLimit = 15;
        resources = new Dictionary<resource, int>()
        {
            [resource.water] = -1,
            [resource.food] = -1,
            [resource.mineral] = 0,
            [resource.material] = -1,
            [resource.money] = 7,
            [resource.labor] = -1,
            [resource.product] = 0,

        };
        cost = new Dictionary<resource, int>()
        {
            [resource.water] = 15,
            [resource.food] = 10,
            [resource.mineral] = 15,
            [resource.material] = 30,
            [resource.money] = 30,
            [resource.labor] = 15,
            [resource.product] = 10,
        };
    }
    public override bool CheckBuildingAllowance(Land land)
    {
        return base.CheckBuildingAllowance(land);
    }
}
