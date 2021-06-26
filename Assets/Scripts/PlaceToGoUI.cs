using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlaceToGoUI : MonoBehaviour
{
    [SerializeField]
    private GameObject placeToGoButton;

    private List<GameObject> buttons;
    private Player playerToMove;
    public Text remainStep;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
        buttons = new List<GameObject>();
    }
    void Update()
    {
        
    }

    public void ButtonClicked(Land landToGo)
    {
        playerToMove.transform.position = landToGo.transform.position;
        playerToMove.locationNow = landToGo;
    }
    public void LoadPlayer(Player player)
    {
        playerToMove = player;
    }
    public void Activated()
    {
        playerToMove = GameObject.Find("Player").GetComponent<Player>();
        Debug.Log(GameControl.remainStep.ToString());
        remainStep.text = "Remain: " + GameControl.remainStep.ToString();
        if (buttons.Count > 0)
        {
            foreach (GameObject button in buttons)
            {
                Destroy(button.gameObject);
            }
            buttons.Clear();
        }



        for (int i = 0; i < playerToMove.locationNow.nearbyLands.Length; i++)
        {
            GameObject button = Instantiate(placeToGoButton) as GameObject;
            button.SetActive(true);
            button.GetComponent<PlaceToGoButton>().SetText(playerToMove.locationNow.nearbyLands[i].landID);
            button.GetComponent<PlaceToGoButton>().SetLand(playerToMove.locationNow.nearbyLands[i]);
            button.transform.SetParent(placeToGoButton.transform.parent, false);
            buttons.Add(button);
        }
    }
//    public void DestoryButton()
//    {
//        GameObject[] buttons = GameObject.FindGameObjectsWithTag("PlaceToGoButton");
//        for(int i=0; i<buttons.Length; i++)
//        {
//            Destroy(buttons[i]);
//        }
//    }
  }
