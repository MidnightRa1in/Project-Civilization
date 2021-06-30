using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DevelopUI : MonoBehaviour
{
    [SerializeField]
    private GameObject nextStageButton;
    [SerializeField]
    private GameObject previewPanel;

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
    private List<Text> texts;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
        buttons = new List<GameObject>();
        resourcePanel = new List<GameObject>();
        texts = new List<Text>()
        {
            water,
            food,
            mineral,
            material,
            money,
            labor,
            product
        };
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Activated()//產生預覽下一狀態按鈕
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

        for (int i = 0; i < player.locationNow.development.nextDevelopment.Count; i++)
        {
            GameObject button = Instantiate(nextStageButton) as GameObject;
            button.SetActive(true);
            button.GetComponent<NextStageButton>().SetText(player.locationNow.development.nextDevelopment[i].stage);
            button.transform.SetParent(nextStageButton.transform.parent, false);
            buttons.Add(button);
        }
        
    }
    public void GeneratePreviewPanel(Dictionary<resource, int> previewRes, Dictionary<resource, int> change)//產生預覽畫面
    {
        if (resourcePanel.Count > 0)
        {
            foreach (GameObject panel in resourcePanel)
            {
                Destroy(panel.gameObject);
            }
            resourcePanel.Clear();
        }

        foreach (KeyValuePair<resource, int> resource in previewRes)
        {
            GameObject panel = Instantiate(previewPanel) as GameObject;
            panel.SetActive(true);
            panel.GetComponent<PreviewPanel>().SetText(resource.Key.ToString(), resource.Value.ToString(), change[resource.Key]);
            panel.transform.SetParent(previewPanel.transform.parent, false);
            resourcePanel.Add(panel);
        }

    }
    public void GenerateCostPanel(landDevelopment name)
    {
        ResetText();
        water.text = Resource.allDevelopmentCost[name][resource.water].ToString();
        if (player.Property[resource.water] < Resource.allDevelopmentCost[name][resource.water]) water.color = Color.red;
        food.text = Resource.allDevelopmentCost[name][resource.food].ToString();
        if (player.Property[resource.food] < Resource.allDevelopmentCost[name][resource.food]) food.color = Color.red;
        mineral.text = Resource.allDevelopmentCost[name][resource.mineral].ToString();
        if (player.Property[resource.mineral] < Resource.allDevelopmentCost[name][resource.mineral]) mineral.color = Color.red;
        material.text = Resource.allDevelopmentCost[name][resource.material].ToString();
        if (player.Property[resource.material] < Resource.allDevelopmentCost[name][resource.material]) material.color = Color.red;
        money.text = Resource.allDevelopmentCost[name][resource.money].ToString();
        if (player.Property[resource.money] < Resource.allDevelopmentCost[name][resource.money]) money.color = Color.red;
        labor.text = Resource.allDevelopmentCost[name][resource.labor].ToString();
        if (player.Property[resource.labor] < Resource.allDevelopmentCost[name][resource.labor]) labor.color = Color.red;
        product.text = Resource.allDevelopmentCost[name][resource.product].ToString();
        if (player.Property[resource.product] < Resource.allDevelopmentCost[name][resource.product]) product.color = Color.red;

    }
    public void ResetText()
    {
        foreach (Text tex in texts)
        {
            tex.text = "";
            tex.color = Color.black;
        }
    }
}
