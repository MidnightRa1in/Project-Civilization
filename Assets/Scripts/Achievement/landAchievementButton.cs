using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class landAchievementButton : AchievementGenreButton
{
    // Start is called before the first frame update
    void Start()
    {
        achievements = new List<Achievement>()
        {
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
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
