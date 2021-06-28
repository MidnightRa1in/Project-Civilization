using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Factory : Building
{
    public Factory()
    {
        buildingName = landBuilding.Factory;
        canBuildOn = new List<landStatus>()
        {
            landStatus.Volcano,
            landStatus.Lake,
            landStatus.Riverside,
            landStatus.Plateau,
            landStatus.Plain,
            landStatus.Seashore,
            landStatus.Savanna
        };
        canNotBuildOn = new List<landDevelopment>()
        {
            landDevelopment.Undeveloped,
            landDevelopment.Village,
            landDevelopment.Town,
            landDevelopment.City
        };
        turnLimit = 10;
        resources = new Dictionary<resource, int>()
        {
            [resource.water] = -2,
            [resource.food] = -2,
            [resource.mineral] = -2,
            [resource.material] = -1,
            [resource.money] = 3,
            [resource.labor] = -1,
            [resource.product] = 7,

        };
        cost = new Dictionary<resource, int>()
        {
            [resource.water] = 30,
            [resource.food] = 25,
            [resource.mineral] = 30,
            [resource.material] = 20,
            [resource.money] = 25,
            [resource.labor] = 20,
            [resource.product] = 20,
        };
    }
    public override bool CheckBuildingAllowance(Land land)
    {
        return base.CheckBuildingAllowance(land);
    }
}
