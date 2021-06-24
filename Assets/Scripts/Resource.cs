using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public static class Resource
{
    public static Dictionary<string, Dictionary<string, int>> allBuilding = new Dictionary<string, Dictionary<string, int>>()
    {
        //["MineralFacility"] = { },
        //["MaterialFacility"] = { },
        //["FishingVillage"] = { },
        //["Farm"] = { },
        //["Market"] = { },
        //["TradeCenter"] = { },
        //["FinanceCenter"] = { },
        //["ArtField"] = { },
        //["ReligiousField"] = { },
        //["Workshop"] = { },
        //["Harbor"] = { },
        ["University"] = university

    };

    public static Dictionary<string, int> mountain = new Dictionary<string, int>()
    {
        ["water"] = 1,
        ["food"] = 1,
        ["mineral"] = 0,
        ["material"] = 3,
        ["money"] = 0,
        ["labor"] = 0,
        ["product"] = 0,

        ["development"] = 0,
    };

    public static Dictionary<string, int> university = new Dictionary<string, int>()
    {
        ["water"] = -2,
        ["food"] = -2,
        ["mineral"] = -1,
        ["material"] = -1,
        ["money"] = 2,
        ["labor"] = 1,
        ["product"] = 2,

        ["development"] = 2,
    };

}
