using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mountain : Land
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
    public static Dictionary<resource, int> resources = new Dictionary<resource, int>()
    {
        [resource.water] = 1,
        [resource.food] = 1,
        [resource.mineral] = 0,
        [resource.material] = 3,
        [resource.money] = 0,
        [resource.labor] = 0,
        [resource.product] = 0,

        [resource.development] = 0,
    };

    public override void Build(Dictionary<resource, int> next)
    {

        base.Build(next);
        Debug.Log("a building in Mountain");
    }
}