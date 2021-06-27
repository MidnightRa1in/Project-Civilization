using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plain : Land
{
    private new void Start()
    {
        base.Start();
        landResource = resources;
    }
    private new void Update()
    {
        base.Update();
    }
    public Dictionary<resource, int> resources = new Dictionary<resource, int>()
    {
        [resource.water] = 1,
        [resource.food] = 2,
        [resource.mineral] = 0,
        [resource.material] = 1,
        [resource.money] = 0,
        [resource.labor] = 1,
        [resource.product] = 0,
    };

    public override void Build(Dictionary<resource, int> next)
    {
        base.Build(next);
        landResource[resource.money] += 1;
        landResource[resource.food] += 1;
    }
}
