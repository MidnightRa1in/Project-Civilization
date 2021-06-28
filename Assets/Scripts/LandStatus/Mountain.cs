using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mountain : Land
{
    private new void Start()
    {
        base.Start();
        resources = new Dictionary<resource, int>()
        {
            [resource.water] = 1,
            [resource.food] = 0,
            [resource.mineral] = 1,
            [resource.material] = 1,
            [resource.money] = 0,
            [resource.labor] = 0,
            [resource.product] = 0,
        };
        status = landStatus.Mountain;
    }
    private new void Update()
    {
        base.Update();
    }


    public override void Build(Dictionary<resource, int> next, landBuilding building)
    {
        if (building == landBuilding.Farm)
        {
            next[resource.labor] -= 1;
            next[resource.material] += 1;
        }
        if (building == landBuilding.Workshop)
        {
            next[resource.mineral] -= 1;
        }
        resources = next;
    }
}