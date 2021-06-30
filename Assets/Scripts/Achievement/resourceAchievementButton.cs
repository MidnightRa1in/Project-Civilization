using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resourceAchievementButton : AchievementGenreButton
{
    // Start is called before the first frame update
    void Start()
    {
        achievements = new List<Achievement>()
        {
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

        };
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
