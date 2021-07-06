using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PreviewButton : MonoBehaviour
{
    [SerializeField]
    private Text buttonName;
    [SerializeField]
    private BuildUI buildUI;
    [SerializeField]
    private ConfirmButton confirm;

    private Player player;
    private PlayerPanel playerPanel;
    private landBuilding buildingName;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
        playerPanel = GameObject.Find("PlayerStatusUI").GetComponent<PlayerPanel>();

    }
    public void SetText(landBuilding newOne)
    {
        buttonName.text = newOne.ToString();
        buildingName = newOne;
    }

    public void buildingClicked()
    {
        confirm.gameObject.GetComponent<Button>().enabled = true;
        Dictionary<resource, int> next = new Dictionary<resource, int>();//土地的變化量
        Dictionary<resource, int> playerNext = new Dictionary<resource, int>();//玩家的變化量
        next = player.locationNow.Preview(buildingName);
        foreach(KeyValuePair<resource,int> res in player.ResourceEachTurn)
        {
            foreach(KeyValuePair<resource, int> build in Resource.allBuilding[buildingName])
            {
                if(res.Key == build.Key)
                {
                    playerNext.Add(res.Key, res.Value + build.Value);
                }
            }
        }
        playerPanel.ReadDictionary(playerNext);
        buildUI.GeneratePreviewETPanel(player.ResourceEachTurn,buildingName);
        buildUI.GenerateCostPanel(buildingName);
        if(CheckUseAllowance(buildingName) == false)
        {
            confirm.gameObject.GetComponent<Button>().enabled = false;
        }
        confirm.loadNext(next);
        confirm.loadConstructedBuilding(buildingName);

    }
    private bool CheckUseAllowance(landBuilding building)
    {
        foreach(KeyValuePair<resource,int> cost in Resource.allBuildingCost[building])
        {
            foreach(KeyValuePair<resource,int> prop in player.Property)
            {
                if (prop.Key == cost.Key)
                {
                    if (prop.Value < cost.Value)
                    {
                        return false;
                    }
                }
            }
        }
        return true;
    }
}
