using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public static class Resource
{
    //Building
    public static Dictionary<resource, int> mineralFacility = new Dictionary<resource, int>()
    {
        [resource.water] = -2,
        [resource.food] = -1,
        [resource.mineral] = 4,
        [resource.material] = -1,
        [resource.money] = -1,
        [resource.labor] = 0,
        [resource.product] = 3,

    };
    public static Dictionary<resource, int> materialFacility = new Dictionary<resource, int>()
    {
        [resource.water] = -2,
        [resource.food] = -1,
        [resource.mineral] = -1,
        [resource.material] = 4,
        [resource.money] = -1,
        [resource.labor] = 0,
        [resource.product] = 3,

    };
    public static Dictionary<resource, int> fishingVillage = new Dictionary<resource, int>()
    {
        [resource.water] = 1,
        [resource.food] = 1,
        [resource.mineral] = 0,
        [resource.material] = -1,
        [resource.money] = 0,
        [resource.labor] = 1,
        [resource.product] = 1,

    };
    public static Dictionary<resource, int> farm = new Dictionary<resource, int>()
    {
        [resource.water] = 1,
        [resource.food] = 2,
        [resource.mineral] = 0,
        [resource.material] = -1,
        [resource.money] = 0,
        [resource.labor] = 1,
        [resource.product] = 0,

    };


    public static Dictionary<resource, int> market = new Dictionary<resource, int>()
    {
        [resource.water] = -1,
        [resource.food] = 0,
        [resource.mineral] = 0,
        [resource.material] = 0,
        [resource.money] = 3,
        [resource.labor] = 0,
        [resource.product] = -1,

    };
    public static Dictionary<resource, int> financeCenter = new Dictionary<resource, int>()
    {
        [resource.water] = -1,
        [resource.food] = -1,
        [resource.mineral] = 0,
        [resource.material] = -1,
        [resource.money] = 5,
        [resource.labor] = -1,
        [resource.product] = 0,

    };

    public static Dictionary<resource, int> artField = new Dictionary<resource, int>()
    {
        [resource.water] = 0,
        [resource.food] = 0,
        [resource.mineral] = 0,
        [resource.material] = -1,
        [resource.money] = -2,
        [resource.labor] = -1,
        [resource.product] = 4,

    };
    public static Dictionary<resource, int> religiousField = new Dictionary<resource, int>()
    {
        [resource.water] = 1,
        [resource.food] = 1,
        [resource.mineral] = -1,
        [resource.material] = 0,
        [resource.money] = -2,
        [resource.labor] = 0,
        [resource.product] = -1,

    };
    public static Dictionary<resource, int> workshop = new Dictionary<resource, int>()
    {
        [resource.water] = -1,
        [resource.food] = 0,
        [resource.mineral] = -1,
        [resource.material] = -2,
        [resource.money] = 1,
        [resource.labor] = 0,
        [resource.product] = 4,

    };
    public static Dictionary<resource, int> factory = new Dictionary<resource, int>()
    {
        [resource.water] = -2,
        [resource.food] = -1,
        [resource.mineral] = -3,
        [resource.material] = -2,
        [resource.money] = 3,
        [resource.labor] = -1,
        [resource.product] = 5,

    };
    public static Dictionary<resource, int> harbor = new Dictionary<resource, int>()
    {
        [resource.water] = 2,
        [resource.food] = -1,
        [resource.mineral] = -1,
        [resource.material] = -2,
        [resource.money] = 2,
        [resource.labor] = -1,
        [resource.product] = 2,

    };
    public static Dictionary<resource, int> university = new Dictionary<resource, int>()
    {
        [resource.water] = -2,
        [resource.food] = -1,
        [resource.mineral] = -1,
        [resource.material] = -1,
        [resource.money] = 2,
        [resource.labor] = -1,
        [resource.product] = 3,

    };

    public static Dictionary<string, Dictionary<resource, int>> allBuilding = new Dictionary<string, Dictionary<resource, int>>()
    {
        ["MineralFacility"] = mineralFacility,
        ["MaterialFacility"] = materialFacility,
        ["FishingVillage"] = fishingVillage,
        ["Farm"] = farm,
        ["Market"] = market,
        ["FinanceCenter"] = financeCenter,
        ["ArtField"] =  artField,
        ["ReligiousField"] = religiousField,
        ["Workshop"] = workshop,
        ["Factory"] = factory,
        ["Harbor"] = harbor,
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

    };

    //Development
    public static Dictionary<resource, int> Town = new Dictionary<resource, int>()
    {
        [resource.water] = 1,
        [resource.food] = 1,
        [resource.mineral] = 0,
        [resource.material] = 0,
        [resource.money] = 1,
        [resource.labor] = 1,
        [resource.product] = 0,

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

    };

    public static Dictionary<landDevelopment, Dictionary<resource, int>> allDevelopment = new Dictionary<landDevelopment, Dictionary<resource, int>>()
    {
        [landDevelopment.Village] = Village,
        [landDevelopment.Town] = Town,
        [landDevelopment.City] = City,
        [landDevelopment.IndustrialArea] = IndustrialArea,
    };
}


