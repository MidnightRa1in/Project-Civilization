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
    private ChooseBuildDevUI chooseBuildDevUI;
    [SerializeField]
    private BuildUI buildUI;
    [SerializeField]
    private DevelopUI developUI;
    [SerializeField]
    private Dice dice;

    [SerializeField]
    private GameObject developOptionButton;
    [SerializeField]
    private GameObject buildOptionButton;

    [SerializeField]
    private Text countingRound;


    public static int remainStep;
    public static int rounds;

    public static bool chooseAction;
    public static bool moving;
    public static bool developing;

    public static bool rollDice;
    public static bool coroutineAllowed;

    public static bool chooseBuildDev;
    public static bool building;
    public static bool developingLand;
    public static bool buildingOptions;





    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
        remainStep = 0;
        rounds = 0;
        moving = false;
        developing = false;
        chooseAction = false;
        rollDice = true;
        chooseBuildDev = false;
        building = false;
        developingLand = false;
        buildingOptions = false;
        foreach (GameObject land in lands)
        {
            land.GetComponent<Land> ().landID = land.name;
        }
    }

    // Update is called once per frame
    void Update()
    {
        countingRound.text = "Round  " + rounds.ToString();
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
                
                moving = false;
                EndofTurn();

            }
        }
        if(chooseBuildDev)
        {
            ChooseBuildDev();
        }
        if(building)
        {
            Build();
        }
        if(developingLand)
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


    public void ChooseAction()
    {
        chooseAcrionAI.gameObject.SetActive(true);
        chooseAction = false;
    }

    public void ChooseBuildDev()
    {
        if (player.locationNow.development.nextDevelopment.Count == 0)
        {
            developOptionButton.SetActive(false);
        }
        if (player.locationNow.buildingsCount == 3)
        {
            buildOptionButton.SetActive(false);
        }
        chooseBuildDevUI.gameObject.SetActive(true);
        chooseBuildDev = false;
        
    }

    public void Build()
    {
        buildUI.gameObject.SetActive(true);
        buildUI.Activated();
        building = false;
    }
    public void Develop()
    {
        developUI.gameObject.SetActive(true);
        developUI.Activated();
        developingLand = false;
    }
    
    public static void EndofTurn()
    {
        coroutineAllowed = true;
        rollDice = true;
        rounds++;
    }
}
