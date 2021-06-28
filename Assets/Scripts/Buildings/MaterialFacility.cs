using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialFacility : Building
{

    public MaterialFacility()
    {
        buildingName = landBuilding.MaterialFacility;
        canBuildOn = new List<landStatus>()
        {
            landStatus.Volcano,
            landStatus.Forest,
            landStatus.Lake,
            landStatus.Riverside,
            landStatus.Plain,
            landStatus.Island,
            landStatus.Swamp,
            landStatus.Mountain
        };
        canNotBuildOn = new List<landDevelopment>()
        {
            landDevelopment.Undeveloped,
        };
        resources = new Dictionary<resource, int>()
        {
            [resource.water] = -1,
            [resource.food] = -1,
            [resource.mineral] = 0,
            [resource.material] = 3,
            [resource.money] = -1,
            [resource.labor] = 0,
            [resource.product] = 2,

        };
        cost = new Dictionary<resource, int>()
        {
            [resource.water] = 5,
            [resource.food] = 5,
            [resource.mineral] = 3,
            [resource.material] = 10,
            [resource.money] = 5,
            [resource.labor] = 3,
            [resource.product] = 5,
        };
    }
    public override bool CheckBuildingAllowance(Land land)
    {
        return base.CheckBuildingAllowance(land);
    }
}
