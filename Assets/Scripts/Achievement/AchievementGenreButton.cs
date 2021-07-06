using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AchievementGenreButton : MonoBehaviour
{
    
    [SerializeField]
    protected AchievementUI UI;
    public List<Achievement> achievements;

    //public AchievementGenreButton()
    //{
    //    achievements = new List<Achievement>()
    //    {
    //        new CenterOfWorld(),
    //        new FinanceDistrict(),
    //        new CapitalOfArt(),
    //        new IndustrialAuthority(),
    //        new HolyCity(),
    //        new AcademyPalace(),
    //        new Manufacturer(),
    //        new TradeArea(),

    //        new AgriculturalCountry(),
    //        new OceanCulture(),
    //        new CityStates(),
    //        new HighPopulation(),
    //        new MarketOrientaed(),
    //        new CraftLand(),

    //        new LandOfFertility(),
    //        new FullOfMaterial(),
    //        new AdvancedInIndustry(),
    //        new AtmosphereOfArt(),
    //        new FlourishingReligion(),
    //        new HigherEducation(),

    //        new OriginOfCivilization(),
    //        new HighLand(),
    //        new DesertClan(),
    //        new Nomads(),
    //        new IslandCountry(),
    //        new GateOfHell(),
    //        new LowLand(),
    //        new GrasslandCommunity(),
    //        new LandDiversity(),
    //    };
    //}

    public void buttonClicked()
    {
        UI.GenerateAchievementButton(achievements);
    }
}
