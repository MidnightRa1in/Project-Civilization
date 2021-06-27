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
            [resource.food] = 1,
            [resource.mineral] = 1,
            [resource.material] = 2,
            [resource.money] = 0,
            [resource.labor] = 0,
            [resource.product] = 0,
        };
    }
    private new void Update()
    {
        base.Update();
    }
    

    public override void Build(Dictionary<resource, int> next)
    {
        base.Build(next);
        base.resources[resource.material] += 1;
        base.resources[resource.labor] -= 1;
        base.resources[resource.product] -= 1;
    }
}