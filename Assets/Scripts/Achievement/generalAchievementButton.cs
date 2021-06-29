using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generalAchievementButton : AchievementGenreButton
{
    
    // Start is called before the first frame update
    void Start()
    {
        achievements = new List<Achievement>()
        {
            new CenterOfWorld(),
        };

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
