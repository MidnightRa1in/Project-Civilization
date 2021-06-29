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
    private landBuilding buildingName;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<Player>();

    }
    public void SetText(landBuilding newOne)
    {
        buttonName.text = newOne.ToString();
        buildingName = newOne;
    }

    public void buildingClicked()
    {
        confirm.gameObject.GetComponent<Button>().enabled = true;
        Dictionary<resource, int> next = new Dictionary<resource, int>();
        next = player.locationNow.Preview(buildingName);
        buildUI.GeneratePreviewPanel(next,buildingName);
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
