using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArtField : Building
{
    public ArtField()
    {
        buildingName = landBuilding.Factory;
        canBuildOn = new List<landStatus>()
        {
            landStatus.Volcano,
            landStatus.Desert,
            landStatus.Lake,
            landStatus.Riverside,
            landStatus.Plateau,
            landStatus.Plain,
            landStatus.Island,
            landStatus.Swamp,
            landStatus.Mountain
          };
        canNotBuildOn = new List<landDevelopment>()
        {
            landDevelopment.Undeveloped,
            landDevelopment.Village,
            landDevelopment.IndustrialArea
        };
        turnLimit = 10;
        resources = new Dictionary<resource, int>()
        {
            [resource.water] = -1,
            [resource.food] = -1,
            [resource.mineral] = 0,
            [resource.material] = -1,
            [resource.money] = -1,
            [resource.labor] = 0,
            [resource.product] = 2,

        };
        cost = new Dictionary<resource, int>()
        {
            [resource.water] = 10,
            [resource.food] = 15,
            [resource.mineral] = 5,
            [resource.material] = 15,
            [resource.money] = 20,
            [resource.labor] = 5,
            [resource.product] = 10,
        };
    }
    public override bool CheckBuildingAllowance(Land land)
    {
        return base.CheckBuildingAllowance(land);
    }
}
