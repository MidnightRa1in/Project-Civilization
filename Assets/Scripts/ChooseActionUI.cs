using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChooseActionUI : MonoBehaviour
{

    
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void moveClicked()
    {
        GameControl.moving = true;
        GameControl.chooseAction = false;
        gameObject.SetActive(false);
    }
    public void developClicked()
    {
        GameControl.developing = true;
        GameControl.chooseAction = false;
        gameObject.SetActive(false);
    }
}

