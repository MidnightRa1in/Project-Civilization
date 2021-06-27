using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerResourcePanel : PlayerPanel
{
    // Start is called before the first frame update
    new void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    new void Update()
    {
        base.Update();
    }

    public override void ReadDictionary()
    {
        water.text = player.Property[resource.water].ToString();
        food.text = player.Property[resource.food].ToString();
        mineral.text = player.Property[resource.mineral].ToString();
        material.text = player.Property[resource.material].ToString();
        money.text = player.Property[resource.money].ToString();
        labor.text = player.Property[resource.labor].ToString();
        product.text = player.Property[resource.product].ToString();
    }
}
