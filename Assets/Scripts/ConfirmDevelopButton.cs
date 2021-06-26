using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfirmDevelopButton : ConfirmButton
{
    [SerializeField]
    private DevelopUI UI;
    
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
        player.locationNow.SetDevelopment(nextStage);
        
        UI.gameObject.SetActive(false);
        GameControl.EndofTurn();

    }
}
