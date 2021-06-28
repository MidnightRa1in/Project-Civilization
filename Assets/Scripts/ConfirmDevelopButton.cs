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
        player.locationNow.Develop(next);
        player.locationNow.SetDevelopment(nextStage);

        if(nextStage == landDevelopment.Village)//�Y�}�o���}�o�g�a�A�N��[�JPlayer�g�a
        {
            player.AddALand(player.locationNow);
        }
        
        UI.gameObject.SetActive(false);
        GameControl.EndofTurn();

    }
}
