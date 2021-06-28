using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class BuildUI : MonoBehaviour
{
    [SerializeField]
    private GameObject previewButton;
    [SerializeField]
    private GameObject previewPanel;
    [SerializeField]
    private GameObject previewETPanel;

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

    private Player player;
    private List<GameObject> buttons;
    private List<GameObject> resourcePanel;
    private List<GameObject> resourceETPanel;


    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
        buttons = new List<GameObject>();
        resourcePanel = new List<GameObject>();
        resourceETPanel = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Activated()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
        if (buttons.Count > 0)
        {
            foreach (GameObject button in buttons)
            {
                Destroy(button.gameObject);
            }
            buttons.Clear();
        }
        if (resourcePanel.Count > 0)
        {
            foreach (GameObject panel in resourcePanel)
            {
                Destroy(panel.gameObject);
            }
            resourcePanel.Clear();
        }
        if (resourceETPanel.Count > 0)
        {
            foreach (GameObject panel in resourceETPanel)
            {
                Destroy(panel.gameObject);
            }
            resourceETPanel.Clear();
        }

        List<Building> building = new List<Building>()
        {
            new MaterialFacility(),
            new MineralFacility(),
            new FishingVillage(),
            new Farm(),
            new Market(),
            new FinanceCenter(),
            new ArtField(),
            new ReligiousField(),
            new Workshop(),
            new Factory(),
            new Harbor(),
            new University(),
        };       
        //Array buildings = Enum.GetValues(typeof(landBuilding));
        foreach(Building build in building)
        {
            if(build.CheckBuildingAllowance(player.locationNow))
            {
                GameObject button = Instantiate(previewButton) as GameObject;
                button.SetActive(true);
                button.GetComponent<PreviewButton>().SetText(build.BuildingName);
                button.transform.SetParent(previewButton.transform.parent, false);
                buttons.Add(button);
                Debug.Log(build.BuildingName);
            }
            
        }
        water.text = "";
        food.text = "";
        mineral.text = "";
        material.text = "";
        money.text = "";
        labor.text = "";
        product.text = "";
        previewETPanel.SetActive(false);
    }
    public void GeneratePreviewPanel(Dictionary<resource, int> previewRes,landBuilding buildingName)//¥Í¦¨preview panel
    {
        if (resourcePanel.Count > 0)
        {
            foreach (GameObject panel in resourcePanel)
            {
                Destroy(panel.gameObject);
            }
            resourcePanel.Clear();
        }

        foreach(KeyValuePair<resource, int> resource in previewRes)
        {
            GameObject panel = Instantiate(previewPanel) as GameObject;
            panel.SetActive(true);
            panel.GetComponent<PreviewPanel>().SetText(resource.Key.ToString(),resource.Value.ToString(),Resource.allBuilding[buildingName][resource.Key].ToString());
            panel.transform.SetParent(previewPanel.transform.parent, false);
            resourcePanel.Add(panel);
        }

        foreach(KeyValuePair<landBuilding, Dictionary<resource, int>> dic in Resource.allBuildingCost)
        {
            if(dic.Key == buildingName)
            {
                water.text = dic.Value[resource.water].ToString();
                food.text = dic.Value[resource.food].ToString();
                mineral.text = dic.Value[resource.mineral].ToString();
                material.text = dic.Value[resource.material].ToString();
                money.text = dic.Value[resource.money].ToString();
                labor.text = dic.Value[resource.labor].ToString();
                product.text = dic.Value[resource.product].ToString();
            }
        }
    }

    public void GeneratePreviewETPanel(Dictionary<resource,int> preview, landBuilding build)
    {
        Dictionary<resource, int> temp = new Dictionary<resource, int>();
        foreach(KeyValuePair<resource,int> resources in preview)
        {
            foreach(KeyValuePair<resource,int> add in Resource.allBuilding[build])
            {
                if(add.Key == resources.Key)
                {
                    temp.Add(resources.Key, resources.Value + add.Value);
                }                
            }
        }

        if (resourceETPanel.Count > 0)
        {
            foreach (GameObject panel in resourceETPanel)
            {
                Destroy(panel.gameObject);
            }
            resourceETPanel.Clear();
        }

        foreach (KeyValuePair<resource, int> resource in temp)
        {
            GameObject panel = Instantiate(previewETPanel) as GameObject;
            panel.SetActive(true);
            panel.GetComponent<PreviewPanel>().SetText(resource.Key.ToString(), resource.Value.ToString(),Resource.allBuilding[build][resource.Key].ToString());
            panel.transform.SetParent(previewETPanel.transform.parent, false);
            resourceETPanel.Add(panel);
        }
        Debug.Log(resourceETPanel.Count);
    }
}
