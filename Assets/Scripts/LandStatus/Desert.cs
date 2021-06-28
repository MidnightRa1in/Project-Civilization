using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desert : Land
{
    private new void Start()
    {
        base.Start();
        resources = new Dictionary<resource, int>()
        {
            [resource.water] = 0,
            [resource.food] = 1,
            [resource.mineral] = 1,
            [resource.material] = 0,
            [resource.money] = 0,
            [resource.labor] = 0,
            [resource.product] = 0,
        };
        status = landStatus.Desert;
    }
    private new void Update()
    {
        base.Update();
    }


    public override void Build(Dictionary<resource, int> next, landBuilding building)
    {
        if (building == landBuilding.Market)
        {
            next[resource.labor] -= 1;
        }
        if (building == landBuilding.Farm)
        {
            next[resource.food] -= 1;
        }
        resources = next;
    }
}
