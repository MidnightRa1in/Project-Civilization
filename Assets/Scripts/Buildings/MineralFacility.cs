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
            [resource.mineral] = 4,
            [resource.material] = -1,
            [resource.money] = 0,
            [resource.labor] = 0,
            [resource.product] = 2,

        };
        cost = new Dictionary<resource, int>()
        {
            [resource.water] = 12,
            [resource.food] = 12,
            [resource.mineral] = 7,
            [resource.material] = 8,
            [resource.money] = 3,
            [resource.labor] = 7,
            [resource.product] = 2,
        };
    }
    public override bool CheckBuildingAllowance(Land land)
    {
        return base.CheckBuildingAllowance(land);
    }
}
