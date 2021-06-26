using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndOptionButton : MonoBehaviour
{
    [SerializeField]
    private ChooseBuildDevUI choose;
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
        choose.gameObject.SetActive(false);
        GameControl.EndofTurn();
    }
}
