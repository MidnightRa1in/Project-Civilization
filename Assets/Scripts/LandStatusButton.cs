using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LandStatusButton : MonoBehaviour
{
    private Player player;
    [SerializeField]
    private LandStatusUI UI;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void buttonClicked()
    {
        UI.LoadLandInfo(player.locationNow);
    }
}
