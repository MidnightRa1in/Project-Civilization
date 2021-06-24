using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PreviewButton : MonoBehaviour
{
    [SerializeField]
    private Text buttonName;
    [SerializeField]
    private BuildUI buildUI;

    private Player player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetText(string text)
    {
        buttonName.text = text;
    }

    public void buildingClicked()
    {
        buildUI.GeneratePreviewPanel(player.locationNow.Preview(buttonName.text));
    }
}
