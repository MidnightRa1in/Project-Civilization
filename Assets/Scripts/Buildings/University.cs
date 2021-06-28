using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class University : Building
{

    public University()
    {
        buildingName = landBuilding.University;
        canBuildOn = new List<landStatus>()
        {
            landStatus.Desert,
            landStatus.Forest,
            landStatus.Lake,
            landStatus.Riverside,
            landStatus.Plateau,
            landStatus.Plain,
            landStatus.Island,
            landStatus.Seashore,
            landStatus.Savanna,
            landStatus.Mountain
        };
        canNotBuildOn = new List<landDevelopment>()
        {
            landDevelopment.Undeveloped,
            landDevelopment.Village,
            landDevelopment.Town,
            landDevelopment.IndustrialArea
        };
        turnLimit = 10;
        resources = new Dictionary<resource, int>()
        {
            [resource.water] = -2,
            [resource.food] = -1,
            [resource.mineral] = -1,
            [resource.material] = -1,
            [resource.money] = 1,
            [resource.labor] = 0,
            [resource.product] = 2,

        };
        cost = new Dictionary<resource, int>()
        {
            [resource.water] = 30,
            [resource.food] = 30,
            [resource.mineral] = 10,
            [resource.material] = 25,
            [resource.money] = 30,
            [resource.labor] = 10,
            [resource.product] = 10,
        };
    }

    public override bool CheckBuildingAllowance(Land land)
    {
        return base.CheckBuildingAllowance(land);
    }
}
