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
    private Dice dice;

    public static int remainStep;
    public static bool moving;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
        remainStep = 0;
        moving = false;
        foreach(GameObject land in lands)
        {
            land.GetComponent<Land> ().landID = land.name;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(moving)
        {
            MovePlayer(player);
            if(remainStep == 0)
            {
                placeToGo.gameObject.SetActive(false);
                player.moveAllowed = false;
                dice.coroutineAllowed = true;
                moving = false;

            }
        }
    }
    public void MovePlayer(Player playerToMove)
    {

        
        if (playerToMove.moveAllowed)
        {
                            
            placeToGo.gameObject.SetActive(true);
            placeToGo.LoadPlayer(playerToMove);
            placeToGo.Activated();
            moving = false;
        }

    }
}
