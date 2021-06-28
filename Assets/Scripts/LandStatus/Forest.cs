using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forest : Land
{
    private new void Start()
    {
        base.Start();
        resources = new Dictionary<resource, int>()
        {
            [resource.water] = 0,
            [resource.food] = 1,
            [resource.mineral] = 0,
            [resource.material] = 2,
            [resource.money] = 0,
            [resource.labor] = 0,
            [resource.product] = 0,
        };
        status = landStatus.Forest;
    }
    private new void Update()
    {
        base.Update();
    }


    public override void Build(Dictionary<resource, int> next, landBuilding building)
    {
        if (building == landBuilding.Farm)
        {
            next[resource.material] -= 1;
        }
        resources = next;
    }
}
