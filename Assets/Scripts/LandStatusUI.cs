using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LandStatusUI : MonoBehaviour
{
    [SerializeField]
    private CloseButton CloseButton;
    [SerializeField]
    private Text landName;
    [SerializeField]
    private Text landStatus;
    [SerializeField]
    private Text landDevelopment;
    [SerializeField]
    private Text landBuilding1;
    [SerializeField]
    private Text landBuilding2;
    [SerializeField]
    private Text landBuilding3;
    [SerializeField]
    private Text water;
    [SerializeField]
    private Text food;
    [SerializeField]
    private Text mineral;
    [SerializeField]
    private Text material;
    [SerializeField]
    private Text money;
    [SerializeField]
    private Text labor;
    [SerializeField]
    private Text product;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LoadLandInfo(Land land)
    {
        landName.text = land.landID;
        landStatus.text = land.status.ToString();
        landDevelopment.text = land.development.stage.ToString();
        for(int i = 0; i < land.buildings.Count; i++)
        {
            switch(i)
            {
                case 0:
                    landBuilding1.text = land.buildings[0].ToString();
                    break;
                case 1:
                    landBuilding2.text = land.buildings[1].ToString();
                    break;
                case 2:
                    landBuilding3.text = land.buildings[2].ToString();
                    break;
                default:
                    break;
            }
        }
        water.text = land.resources[resource.water].ToString();
        food.text = land.resources[resource.food].ToString();
        mineral.text = land.resources[resource.mineral].ToString();
        material.text = land.resources[resource.material].ToString();
        money.text = land.resources[resource.money].ToString();
        labor.text = land.resources[resource.labor].ToString();
        product.text = land.resources[resource.product].ToString();

    }
    
}
