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
            [resource.water] = 30,
            [resource.food] = 40,
            [resource.mineral] = 25,
            [resource.material] = 25,
            [resource.money] = 20,
            [resource.labor] = 20,
            [resource.product] = 20,
        };
    }
    public override bool CheckBuildingAllowance(Land land)
    {
        return base.CheckBuildingAllowance(land);
    }
}
