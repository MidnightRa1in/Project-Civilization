using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Volcano : Land
{
    private new void Start()
    {
        base.Start();
        resources = new Dictionary<resource, int>()
        {
            [resource.water] = 1,
            [resource.food] = 1,
            [resource.mineral] = 2,
            [resource.material] = 1,
            [resource.money] = 0,
            [resource.labor] = 0,
            [resource.product] = 0,
        };
        status = landStatus.Volcano;
    }
    private new void Update()
    {
        base.Update();
    }


    public override void Build(Dictionary<resource, int> next,landBuilding building)
    {
        if (building == landBuilding.MineralFacility)
        {
            next[resource.mineral] += 2;
        }
        resources = next;
    }
}
