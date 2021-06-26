using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Development
{
    public List<Development> nextDevelopment;
    public landDevelopment stage;

    public Development(landDevelopment stage)
    {
        this.stage = stage;
        nextDevelopment = new List<Development>();
    }
    public Development()
    {

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
