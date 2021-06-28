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

        if(nextStage == landDevelopment.Village)//若開發未開發土地，將其加入Player土地
        {
            player.AddALand(player.locationNow);
        }
        switch(player.locationNow.development.stage)
        {
            case landDevelopment.Village:
                player.locationNow.gameObject.transform.localScale += new Vector3(1.1f, 1.1f, 1.1f);
                break;
            case landDevelopment.Town:
                player.locationNow.gameObject.transform.localScale += new Vector3(1.2f, 1.2f, 1.2f);
                break;
            case landDevelopment.City:
                player.locationNow.gameObject.transform.localScale += new Vector3(1.3f, 1.3f, 1.3f);
                break;
            case landDevelopment.IndustrialArea:
                player.locationNow.gameObject.transform.localScale += new Vector3(1.3f, 1.3f, 1.3f);
                break;
            default: break;

        }
        
        UI.gameObject.SetActive(false);
        GameControl.EndofTurn();

    }
}
