using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool moveAllowed;
    public Land locationNow;
    [SerializeField]
    private Land Clotho1AsSpawn;
    private Land[] lands;
    // Start is called before the first frame update
    void Start()
    {        
        transform.position = Clotho1AsSpawn.transform.position;
        moveAllowed = false;
        locationNow = Clotho1AsSpawn;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
