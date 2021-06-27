using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lake : Land
{
    private new void Start()
    {
        base.Start();
        resources = new Dictionary<resource, int>()
        {
            [resource.water] = 2,
            [resource.food] = 1,
            [resource.mineral] = 1,
            [resource.material] = 1,
            [resource.money] = 0,
            [resource.labor] = 0,
            [resource.product] = 0,
        };
        status = landStatus.Lake;
    }
    private new void Update()
    {
        base.Update();
    }
    

    public override void Build(Dictionary<resource, int> next)
    {
        base.Build(next);
        resources[resource.water] += 1;
        resources[resource.labor] += 1;
        resources[resource.material] -= 1;
    }
}
