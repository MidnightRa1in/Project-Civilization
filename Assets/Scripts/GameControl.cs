using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class GameControl : MonoBehaviour
{
    [SerializeField]
    private GameObject[] lands;
    [SerializeField]
    private static Player player;
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
    private LandStatusUI landStatusUI;
    [SerializeField]
    private PlayerPanel playerPanel;
    [SerializeField]
    private GameObject startPanel;
    [SerializeField]
    private GameObject manual;
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

    public static bool start;
    public static bool chooseAction;
    public static bool moving;
    public static bool developing;

    public static bool rollDice;
    public static bool coroutineAllowed;

    public static bool chooseBuildDev;
    public static bool building;
    public static bool developingLand;
    public static bool buildingOptions;

    private static string filePath;
    private static string action;
    private static string description;

    private static List<Achievement> achievements;
    private static List<Achievement> achievementsReached;
    private static int totalPoints;
    [SerializeField]
    private static GameObject gameOverPanel;
    [SerializeField]
    private static GameObject gameOverDescription;
    [SerializeField]
    private static GameObject achievementPanel;
    [SerializeField]
    private static GameObject total;
    [SerializeField]
    private static GameObject resultPanel;
    
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
        gameOverPanel = GameObject.Find("GameOver");
        gameOverDescription = GameObject.Find("GameOverDiscription");
        achievementPanel = GameObject.Find("achievementsReachedPanel");
        total = GameObject.Find("totalPoint");
        resultPanel = GameObject.Find("ResultPanel");

        start = true;

        remainStep = 0;
        rounds = 0;
       
        coroutineAllowed = true;
        moving = false;
        developing = false;
        chooseAction = false;
        rollDice = false;
        chooseBuildDev = false;
        building = false;
        developingLand = false;
        buildingOptions = false;
        filePath = Application.dataPath + "/player_log.txt";
        achievements = new List<Achievement>()
        {
            new CenterOfWorld(),
            new FinanceDistrict(),
            new CapitalOfArt(),
            new IndustrialAuthority(),
            new HolyCity(),
            new AcademyPalace(),
            new Manufacturer(),
            new TradeArea(),

            new AgriculturalCountry(),
            new OceanCulture(),
            new CityStates(),
            new HighPopulation(),
            new MarketOrientaed(),
            new CraftLand(),

            new LandOfFertility(),
            new FullOfMaterial(),
            new AdvancedInIndustry(),
            new AtmosphereOfArt(),
            new FlourishingReligion(),
            new HigherEducation(),

            new OriginOfCivilization(),
            new HighLand(),
            new DesertClan(),
            new Nomads(),
            new IslandCountry(),
            new GateOfHell(),
            new LowLand(),
            new GrasslandCommunity(),
            new LandDiversity(),
        };
        achievementsReached = new List<Achievement>();

        ClearTxt();
        foreach (GameObject land in lands)
        {
            land.GetComponent<Land> ().landID = land.name;
            land.GetComponent<Land>().landStatusUI = landStatusUI;
        }
        playerPanel.ReadDictionary();
        gameOverPanel.SetActive(false);
        achievementPanel.SetActive(false);
        resultPanel.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        countingRound.text = "Round  " + rounds.ToString();
        if(start)
        {
            Begin();
            start = false;
        }
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
                SetDescription(player.locationNow.name);
                SetAction("Move");
                EndofTurn();
                playerPanel.ReadDictionary();

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
        developOptionButton.SetActive(true);
        buildOptionButton.SetActive(true);
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

    public static void SetAction(string act)
    {
        action = act;
    }

    public static void SetDescription(string des)
    {
        description = des;
    }

    private static string GetResourceEachTurnData()
    {
        Dictionary<resource, int> resET = player.ResourceEachTurn;
        string etData = "";

        foreach(KeyValuePair<resource, int> item in resET)
        {
            etData += item.Value + ",";
        }

        return etData;
    }

    private static string GetProp()
    {
        Dictionary<resource, int> prop = player.Property;
        string propData = "";

        foreach (KeyValuePair<resource, int> item in prop)
        {
            propData += item.Value + ",";
        }

        propData = propData.Remove(propData.Length - 1);

        return propData;
    }

    private static void ClearTxt()
    {
        File.WriteAllText(filePath, "");
    }
    private static void WriteToTxtFile()
    {
        string header = "Round,Act,Des,W,F,Mi,Ma,Mo,La,P, ,W,F,Mi,Ma,Mo,La,P\n";

        if (rounds == 1)
        {
            File.WriteAllText(filePath, header);
        }

        string row = rounds.ToString() + "," + action + "," + description + "," +
            GetResourceEachTurnData() + "," + GetProp() + "\n";
        File.AppendAllText(filePath, row);
    }
    
    public static void EndofTurn()
    {
        coroutineAllowed = true;
        rollDice = true;
        rounds++;
        player.CountResource();
        player.GetResource();
        player.Inventory();
        //WriteToTxtFile();
        Debug.Log(rounds);
        if(rounds > 35 || Lose())
        {
            Debug.Log(rounds);
            Debug.Log(Lose());
            EndGame();
        }
    }

    public static void EndGame()
    {
        player.gameObject.SetActive(false);
        rollDice = false;
        totalPoints = 0;
        foreach(Achievement ach in achievements)
        {
            totalPoints += ach.Check(player);
            if(ach.Check(player) > 0 )
            {
                achievementsReached.Add(ach);
            }
        }
        gameOverPanel.gameObject.SetActive(true);
        if (Lose())
        {           
            gameOverDescription.GetComponent<Text>().text = "Game Over! You are out of resources";
        }
        else
        {
            gameOverDescription.GetComponent<Text>().text = "Game Over! Take a look to the achievements you have reached";
        }
        if(achievementsReached.Count>0)
        {
            foreach (Achievement ach in achievementsReached)
            {
                GameObject panel = Instantiate(achievementPanel) as GameObject;
                panel.SetActive(true);
                panel.GetComponent<GameOverPointPanel>().SetText(ach, ach.Points);
                panel.transform.SetParent(achievementPanel.transform.parent, false);
            }
            total.GetComponent<Text>().text = totalPoints.ToString();
        }
        else
        {
            total.GetComponent<Text>().text = "0";
        }
        

    }
    private static bool Lose()
    {
        foreach(KeyValuePair<resource, int> res in player.Property)
        {
            if (res.Value < 0)
            {
                return true;
            }
        }
        return false;
    }

    private void Begin()
    {
        startPanel.SetActive(true);
    }
    public void StartGame()
    {
        manual.SetActive(true);
        startPanel.SetActive(false);
        rollDice = true;
    }
}

