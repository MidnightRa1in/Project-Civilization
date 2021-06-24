using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice : MonoBehaviour
{
    private Sprite[] diceSides;
    private SpriteRenderer rend;
    public bool coroutineAllowed;
    private static int value;
    private Player playerToMove;
    public static int Value
    {
        get { return value; }
    }

    // Start is called before the first frame update
    void Start()
    {
        playerToMove = GameObject.Find("Player").GetComponent<Player>();
        rend = GetComponent<SpriteRenderer>();
        diceSides = Resources.LoadAll<Sprite>("Dice/");
        rend.sprite = diceSides[5];
        coroutineAllowed = true;
    }

    // Update is called once per frame
    void OnMouseDown()
    {
        if(coroutineAllowed && GameControl.rollDice)
        StartCoroutine("RollTheDice");
    }
    IEnumerator RollTheDice()
    {
        coroutineAllowed = false;
        int randomDiceSide = 0;
        for(int i =0; i <=10; i++)
        {
            randomDiceSide = Random.Range(0, 6);
            rend.sprite = diceSides[randomDiceSide];
            yield return new WaitForSeconds(0.03f);
        }
        value = randomDiceSide +1;
        GameControl.remainStep = value;
        playerToMove.moveAllowed = true;
        GameControl.chooseAction = true;
        GameControl.rollDice = false;
        Debug.Log(playerToMove.locationNow.landBuilding.Count);
        
    }


}
