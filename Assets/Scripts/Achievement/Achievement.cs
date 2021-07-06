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
    protected int points;

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
    public int Points
    {
        get { return points; }
    }
    public Achievement()
    {
    }

    public int Check(Player player)
    {
        foreach(KeyValuePair<landBuilding, int> build in buildingReq)
        {
            if (player.PlayerBuilings[build.Key] < build.Value) return 0;
        }
        foreach (KeyValuePair<landDevelopment, int> dev in developReq)
        {
            if (player.PlayerDevelopments[dev.Key] < dev.Value) return 0;
        }
        foreach (KeyValuePair<landStatus, int> sta in statusReq)
        {
            if (player.PlayerLandStatus[sta.Key] < sta.Value) return 0;
        }
        foreach (KeyValuePair<resource, int> res in resourceReq)
        {
            if (player.Property[res.Key] < res.Value) return 0;
        }
        if (player.DevelopedLands.Count < developedLandsReq) return 0;
        return points;
    }

}
