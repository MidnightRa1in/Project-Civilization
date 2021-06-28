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
            [resource.food] = 1,
            [resource.mineral] = 0,
            [resource.material] = 0,
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


    public override void Build(Dictionary<resource, int> next, landBuilding building)
    {
        if (building == landBuilding.FinanceCenter)
        {
            next[resource.product] += 1;
        }
        if (building == landBuilding.Factory)
        {
            next[resource.water] -= 1;
            next[resource.product] += 1;
        }
        if (building == landBuilding.Harbor)
        {
            next[resource.money] += 1;
        }
        resources = next;
    }
}
