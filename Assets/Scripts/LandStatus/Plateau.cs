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
            [resource.food] = 0,
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


    public override void Build(Dictionary<resource, int> next, landBuilding building)
    {
        if (building == landBuilding.MineralFacility)
        {
            next[resource.mineral] += 1;
        }
        if (building == landBuilding.Factory)
        {
            next[resource.product] += 1;
        }
        if (building == landBuilding.ArtField)
        {
            next[resource.labor] -= 1;
        }
        if (building == landBuilding.ReligiousField)
        {
            next[resource.labor] -= 1;
        }
        resources = next;
    }
}
