using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerETResourcePanel : PlayerPanel
{
    // Start is called before the first frame update
    new void Start()
    {
        gameObject.SetActive(false);
        base.Start();
    }

    // Update is called once per frame
    new void Update()
    {
        base.Update();
    }
    public override void ReadDictionary()
    {
        water.text = player.ResourceEachTurn[resource.water].ToString();
        food.text = player.ResourceEachTurn[resource.food].ToString();
        mineral.text = player.ResourceEachTurn[resource.mineral].ToString();
        material.text = player.ResourceEachTurn[resource.material].ToString();
        money.text = player.ResourceEachTurn[resource.money].ToString();
        labor.text = player.ResourceEachTurn[resource.labor].ToString();
        product.text = player.ResourceEachTurn[resource.product].ToString();
    }
}
