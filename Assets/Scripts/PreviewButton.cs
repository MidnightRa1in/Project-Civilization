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

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetText(landBuilding newOne)
    {
        buttonName.text = newOne.ToString();
        buildingName = newOne;
    }

    public void buildingClicked()
    {
        Dictionary<resource, int> next = new Dictionary<resource, int>();
        next = player.locationNow.Preview(buildingName);
        buildUI.GeneratePreviewPanel(next,buildingName);
        buildUI.GeneratePreviewETPanel(player.ResourceEachTurn,buildingName);
        confirm.loadNext(next);
        confirm.loadConstructedBuilding(buildingName);

    }
}
