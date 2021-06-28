using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineralFacility : Building
{
    public new Dictionary<resource, int> resources;
    public new Dictionary<resource, int> cost;
    public MineralFacility()
    {
        buildingName = landBuilding.MineralFacility;
        canBuildOn = new List<landStatus>()
        {
            landStatus.Volcano,
            landStatus.Desert,
            landStatus.Plateau,
            landStatus.Swamp,
            landStatus.Mountain

        };
        canNotBuildOn = new List<landDevelopment>()
        {
            landDevelopment.Undeveloped,
            landDevelopment.Village,
        };
        resources = new Dictionary<resource, int>()
        {
            [resource.water] = -2,
            [resource.food] = -1,
            [resource.mineral] = 3,
            [resource.material] = -1,
            [resource.money] = -1,
            [resource.labor] = 0,
            [resource.product] = 2,

        };
        cost = new Dictionary<resource, int>()
        {
            [resource.water] = 10,
            [resource.food] = 5,
            [resource.mineral] = 5,
            [resource.material] = 10,
            [resource.money] = 10,
            [resource.labor] = 5,
            [resource.product] = 5,
        };
    }
    public override bool CheckBuildingAllowance(Land land)
    {
        return base.CheckBuildingAllowance(land);
    }
}
