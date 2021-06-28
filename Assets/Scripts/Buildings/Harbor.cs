using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Harbor : Building
{

    public Harbor()
    {
        buildingName = landBuilding.Harbor;
        canBuildOn = new List<landStatus>()
        {
            landStatus.Island,
            landStatus.Seashore
        };
        canNotBuildOn = new List<landDevelopment>()
        {
            landDevelopment.Undeveloped,
            landDevelopment.Village,
        };
        resources = new Dictionary<resource, int>()
        {
            [resource.water] = 0,
            [resource.food] = -1,
            [resource.mineral] = -1,
            [resource.material] = -2,
            [resource.money] = 3,
            [resource.labor] = -1,
            [resource.product] = 3,

        };
        cost = new Dictionary<resource, int>()
        {
            [resource.water] = 15,
            [resource.food] = 10,
            [resource.mineral] = 20,
            [resource.material] = 15,
            [resource.money] = 20,
            [resource.labor] = 10,
            [resource.product] = 10,
        };
    }
    public override bool CheckBuildingAllowance(Land land)
    {
        return base.CheckBuildingAllowance(land);
    }
}
