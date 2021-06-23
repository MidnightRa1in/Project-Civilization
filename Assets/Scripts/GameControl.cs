using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{
    [SerializeField]
    private GameObject[] lands;
    [SerializeField]
    private Player player;
    [SerializeField]
    private PlaceToGoUI placeToGo;
    [SerializeField]
    private ChooseActionUI chooseAcrionAI;
    [SerializeField]
    private DevelopUI developUI;
    [SerializeField]
    private Dice dice;
    

    public static int remainStep;
    public static bool chooseAction;
    public static bool moving;
    public static bool developing;
    public static bool rollDice;



    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
        remainStep = 0;
        moving = false;
        developing = false;
        chooseAction = false;
        rollDice = true;
        foreach(GameObject land in lands)
        {
            land.GetComponent<Land> ().landID = land.name;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (chooseAction)
        {            
            ChooseAction();
        }
        if (moving)
        {
            MovePlayer(player);
            if(remainStep == 0)
            {
                placeToGo.gameObject.SetActive(false);
                player.moveAllowed = false;
                dice.coroutineAllowed = true;
                moving = false;
                rollDice = true;

            }
        }
        if(developing)
        {
            Develop();
        }
    }
    public void MovePlayer(Player playerToMove)
    {
                                  
            placeToGo.gameObject.SetActive(true);
            placeToGo.LoadPlayer(playerToMove);
            placeToGo.Activated();
            moving = false;

    }

    public void Develop()
    {
        developUI.gameObject.SetActive(true);
        developing = false;
    }

    public void ChooseAction()
    {
        chooseAcrionAI.gameObject.SetActive(true);
    }
}
