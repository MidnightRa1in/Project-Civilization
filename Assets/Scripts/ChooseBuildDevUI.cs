using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseBuildDevUI : MonoBehaviour
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
     public void buildClicked()
    {
        GameControl.building = true;
        GameControl.chooseBuildDev = false;
        gameObject.SetActive(false);
    }
    public void developLandClicked()
    {
        GameControl.developingLand = true;
        GameControl.chooseBuildDev = false;
        gameObject.SetActive(false);
    }
}
