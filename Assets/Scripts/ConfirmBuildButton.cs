using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfirmBuildButton : ConfirmButton
{
    [SerializeField]
    private BuildUI UI;
    [SerializeField]
    private PlayerPanel playerPanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public override void buttonClicked()
    {
        
        player.UseResource(constructedBuilding);
        player.locationNow.Build(next, constructedBuilding);
        player.locationNow.buildings.Add(constructedBuilding);
        player.locationNow.buildingsCount++;
        UI.gameObject.SetActive(false);
        GameControl.SetDescription(constructedBuilding.ToString());
        GameControl.SetAction("Build");
        GameControl.EndofTurn();
        playerPanel.ReadDictionary();

    }
}
