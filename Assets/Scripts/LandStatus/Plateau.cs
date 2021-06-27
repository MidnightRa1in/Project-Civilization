using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plateau : Land
{
    private new void Start()
    {
        base.Start();
        resources = new Dictionary<resource, int>()
        {
            [resource.water] = 0,
            [resource.food] = 1,
            [resource.mineral] = 2,
            [resource.material] = 1,
            [resource.money] = 0,
            [resource.labor] = 0,
            [resource.product] = 0,
        };
        status = landStatus.Plateau;
    }
    private new void Update()
    {
        base.Update();
    }


    public override void Build(Dictionary<resource, int> next)
    {
        base.Build(next);
        resources[resource.water] -= 1;
        resources[resource.food] -= 1;
        resources[resource.product] += 1;
        resources[resource.material] += 1;
    }
}
