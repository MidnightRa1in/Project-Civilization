using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlaceToGoButton : MonoBehaviour
{
    [SerializeField]
    private Text buttonName;
    [SerializeField]
    private PlaceToGoUI UI;

    private Land thisLand;


    public void SetText(string text)
    {
        buttonName.text = text;
    }
    public void SetLand(Land land)
    {
        thisLand = land;
    }
    public void OnClick()
    {
        UI.ButtonClicked(thisLand);
        GameControl.remainStep--;
        GameControl.moving = true;
        //UI.DestoryButton();
        UI.gameObject.SetActive(false);
        

    }
}
