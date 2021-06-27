using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seashore : Land
{
    private new void Start()
    {
        base.Start();
        resources = new Dictionary<resource, int>()
        {
            [resource.water] = 1,
            [resource.food] = 2,
            [resource.mineral] = 0,
            [resource.material] = 1,
            [resource.money] = 0,
            [resource.labor] = 0,
            [resource.product] = 0,
        };
        status = landStatus.Seashore;
    }
    private new void Update()
    {
        base.Update();
    }


    public override void Build(Dictionary<resource, int> next)
    {
        base.Build(next);
        resources[resource.water] += 1;
        resources[resource.food] += 1;
        resources[resource.material] -= 1;
    }
}
