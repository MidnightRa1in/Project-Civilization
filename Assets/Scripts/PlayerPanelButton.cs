using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPanelButton : MonoBehaviour
{
    [SerializeField]
    private GameObject showThisOne;
    [SerializeField]
    private GameObject hideThisOne;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     public void buttonClicked()
    {
        hideThisOne.SetActive(false);
        showThisOne.SetActive(true);
    }
}
