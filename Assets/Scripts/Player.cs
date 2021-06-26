using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool moveAllowed;
    public bool developAllowed;
    public Land locationNow;
    [SerializeField]
    private Land Athena11AsSpawn;
    public Land[] lands;
    public List<Land> llands;

    // Start is called before the first frame update
    void Start()
    {        
        transform.position = Athena11AsSpawn.transform.position;
        moveAllowed = false;
        locationNow = Athena11AsSpawn;
        llands = new List<Land>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
