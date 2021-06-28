using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Riverside : Land
{
    private new void Start()
    {
        base.Start();
        resources = new Dictionary<resource, int>()
        {
            [resource.water] = 2,
            [resource.food] = 1,
            [resource.mineral] = 0,
            [resource.material] = 0,
            [resource.money] = 0,
            [resource.labor] = 1,
            [resource.product] = 0,
        };
        status = landStatus.Riverside;
    }
    private new void Update()
    {
        base.Update();
    }


    public override void Build(Dictionary<resource, int> next, landBuilding building)
    {
        if (building == landBuilding.FishingVillage)
        {
            next[resource.food] += 1;
        }
        if (building == landBuilding.Factory)
        {
            next[resource.water] += 1;
        }
        resources = next;
    }
}
