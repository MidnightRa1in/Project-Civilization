using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerResourcePanel : MonoBehaviour
{
    [SerializeField]
    private Text resourceName;
    [SerializeField]
    private Text propertyAmount;
    [SerializeField]
    private Text changeAmount;


    ////testingIcon
    //private Dictionary<resource, Sprite> resourceIcon;
    //private Sprite water;
    //private Sprite food;
    //private Sprite mineral;
    //private Sprite material;
    //private Sprite money;
    //private Sprite labor;
    //private Sprite product;

    // Start is called before the first frame update
    void Start()
     {
        //water = Resources.Load<Sprite>("ResourceIcon/Water");
        //food = Resources.Load<Sprite>("ResourceIcon/Food");
        //mineral = Resources.Load<Sprite>("ResourceIcon/Mineral");
        //material = Resources.Load<Sprite>("ResourceIcon/Material");
        //money = Resources.Load<Sprite>("ResourceIcon/Money");
        //labor = Resources.Load<Sprite>("ResourceIcon/Labor");
        //product = Resources.Load<Sprite>("ResourceIcon/Product");
        //resourceIcon = new Dictionary<resource, Sprite>()
        //{
        //    [resource.water] = water,
        //    [resource.food] = food,
        //    [resource.mineral] = mineral,
        //    [resource.material] = material,
        //    [resource.money] = money,
        //    [resource.labor] = labor,
        //    [resource.product] = product,
        //};
        //test.sprite = resourceIcon[resource.labor];


    }

    // Update is called once per frame
    void Update()
    {
    }

    public void SetText(resource name, int property, int change)
    {
        
        resourceName.text = name.ToString();
        propertyAmount.text = property.ToString();
        if (change >= 0)
        {
            changeAmount.text = "(+" + change.ToString() + ")";
        }
        else
        {
            changeAmount.text = "(" + change.ToString() + ")";
        }       
    }
}
