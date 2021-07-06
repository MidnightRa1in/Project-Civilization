using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerPanel : MonoBehaviour
{
    protected Player player;
    [SerializeField]
    private GameObject resourcePanel;

    private List<GameObject> panels;

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
        gameObject.SetActive(false);
        player = GameObject.Find("Player").GetComponent<Player>();
        panels = new List<GameObject>();

        ////test
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
        ReadDictionary();
    }

    public void ReadDictionary()
    {
        cleanPanels();
        foreach(KeyValuePair<resource, int> res in player.Property)
        {
            GameObject panel = Instantiate(resourcePanel) as GameObject;
            panel.SetActive(true);
            panel.GetComponent<PlayerResourcePanel>().SetText(res.Key, res.Value, player.ResourceEachTurn[res.Key]);
            panel.transform.SetParent(resourcePanel.transform.parent, false);
            panels.Add(panel);
        }
    }
    public void ReadDictionary(Dictionary<resource,int> next)
    {
        cleanPanels();
        foreach (KeyValuePair<resource, int> res in player.Property)
        {
            GameObject panel = Instantiate(resourcePanel) as GameObject;
            panel.SetActive(true);
            panel.GetComponent<PlayerResourcePanel>().SetText(res.Key, res.Value, next[res.Key]);
            panel.transform.SetParent(resourcePanel.transform.parent, false);
            panels.Add(panel);
        }
    }
    private void cleanPanels()
    {
        if (panels.Count > 0)
        {
            foreach (GameObject panel in panels)
            {
                Destroy(panel.gameObject);
            }
            panels.Clear();
        }
    }

}
