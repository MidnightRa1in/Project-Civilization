using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfirmBuildButton : ConfirmButton
{
    [SerializeField]
    private BuildUI UI;
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
        base.buttonClicked();
        player.locationNow.buildings.Add(constructedBuilding);
        player.locationNow.buildingsCount++;
        UI.gameObject.SetActive(false);
        GameControl.EndofTurn();

    }
}