using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public static class Resource
{

    public static Dictionary<resource, int> university = new Dictionary<resource, int>()
    {
        [resource.water] = -2,
        [resource.food] = -2,
        [resource.mineral] = -1,
        [resource.material] = -1,
        [resource.money] = 2,
        [resource.labor] = 1,
        [resource.product] = 2,

        [resource.development] = 2,
    };

    public static Dictionary<string, Dictionary<resource, int>> allBuilding = new Dictionary<string, Dictionary<resource, int>>()
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

    public static Dictionary<resource, int> Village = new Dictionary<resource, int>()
    {
        [resource.water] = 1,
        [resource.food] = 1,
        [resource.mineral] = 0,
        [resource.material] = 1,
        [resource.money] = 0,
        [resource.labor] = 1,
        [resource.product] = 0,

        [resource.development] = 0,
    };

    public static Dictionary<resource, int> Town = new Dictionary<resource, int>()
    {
        [resource.water] = 1,
        [resource.food] = 1,
        [resource.mineral] = 0,
        [resource.material] = 0,
        [resource.money] = 1,
        [resource.labor] = 1,
        [resource.product] = 0,

        [resource.development] = 0,
    };

    public static Dictionary<resource, int> City = new Dictionary<resource, int>()
    {
        [resource.water] = -1,
        [resource.food] = 1,
        [resource.mineral] = 0,
        [resource.material] = -1,
        [resource.money] = 2,
        [resource.labor] = 1,
        [resource.product] = 1,

        [resource.development] = 0,
    };

    public static Dictionary<resource, int> IndustrialArea = new Dictionary<resource, int>()
    {
        [resource.water] = -1,
        [resource.food] = -1,
        [resource.mineral] = -1,
        [resource.material] = 0,
        [resource.money] = 2,
        [resource.labor] = 0,
        [resource.product] = 3,

        [resource.development] = 0,
    };

    public static Dictionary<landDevelopment, Dictionary<resource, int>> allDevelopment = new Dictionary<landDevelopment, Dictionary<resource, int>>()
    {
        [landDevelopment.Village] = Village,
        [landDevelopment.Town] = Town,
        [landDevelopment.City] = City,
        [landDevelopment.IndustrialArea] = IndustrialArea,
    };
}


