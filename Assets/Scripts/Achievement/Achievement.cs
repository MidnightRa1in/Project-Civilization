using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Achievements
{
    CenterOfWorld,
    FinanceDistrict,
    CapitalOfArt,
    IndustrialAuthority,
    HolyCity,
    AcademyPalace,
    Manufacturer,
    TradeArea,

    AgriculturalCountry,
    OceanCulture,
    CityStates,
    HighPopulation,
    MarketOrientaed,
    CraftLand,

    LandOfFertility,
    FullOfMaterial,
    AdvancedInIndustry,
    AtmosphereOfArt,
    FlourishingReligion,
    HigherEducation,

    OriginOfCivilization,
    HighLand,
    DesertClan,
    Nomads,
    IslandCountry,
    GateOfHell,
    LowLand,
    GrasslandCommunity,
    LandDiversity

}
public class Achievement
{
    protected Player player;
    protected Dictionary<landBuilding, int> buildingReq;
    protected Dictionary<landDevelopment, int> developReq;
    protected Dictionary<resource, int> resourceReq;
    protected Dictionary<landStatus, int> statusReq;
    protected int developedLandsReq;
    protected Achievements achievementName;

    public Dictionary<landBuilding, int> BuildingReq
    {
        get { return buildingReq; }
    }
    public Dictionary<landDevelopment, int> DevelopReq
    {
        get { return developReq; }
    }
    public Dictionary<resource, int> ResourceReq
    {
        get { return resourceReq; }
    }
    public Dictionary<landStatus, int> StatusReq
    {
        get { return statusReq; }
    }
    public int DevelopedLandsReq
    {
        get { return developedLandsReq; }
    }
    public Achievements AchievementName
    {
        get { return achievementName; }
    }
    public Achievement()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
    }

}
