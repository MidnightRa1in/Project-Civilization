using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndOptionButton : MonoBehaviour
{
    [SerializeField]
    private ChooseActionUI choose;
    [SerializeField]
    private PlayerPanel playerPanel;
    // Start is called before the first frame update
    void Start()
    {
        playerPanel = GameObject.FindWithTag("PlayerStatusUI").GetComponent<PlayerPanel>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void buttonClicked()
    {
        choose.gameObject.SetActive(false);
        GameControl.SetAction("End");
        GameControl.EndofTurn();
        playerPanel.ReadDictionary();
    }
}
