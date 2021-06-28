using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public static class Resource
{

    //Building
    public static Dictionary<landBuilding, Dictionary<resource, int>> allBuilding = new Dictionary<landBuilding, Dictionary<resource, int>>()
    {
        [landBuilding.MineralFacility] = new MineralFacility().resources,
        [landBuilding.MaterialFacility] = new MaterialFacility().resources,
        [landBuilding.FishingVillage] = new FishingVillage().resources,
        [landBuilding.Farm] = new Farm().resources,
        [landBuilding.Market] = new Market().resources,
        [landBuilding.FinanceCenter] = new FinanceCenter().resources,
        [landBuilding.ArtField] = new ArtField().resources,
        [landBuilding.ReligiousField] = new ReligiousField().resources,
        [landBuilding.Workshop] = new Workshop().resources,
        [landBuilding.Factory] = new Factory().resources,
        [landBuilding.Harbor] = new Harbor().resources,
        [landBuilding.University] = new University().resources

    };
    public static Dictionary<landBuilding, Dictionary<resource, int>> allBuildingCost = new Dictionary<landBuilding, Dictionary<resource, int>>()
    {
        [landBuilding.MineralFacility] = new MineralFacility().cost,
        [landBuilding.MaterialFacility] = new MaterialFacility().cost,
        [landBuilding.FishingVillage] = new FishingVillage().cost,
        [landBuilding.Farm] = new Farm().cost,
        [landBuilding.Market] = new Market().cost,
        [landBuilding.FinanceCenter] = new FinanceCenter().cost,
        [landBuilding.ArtField] = new ArtField().cost,
        [landBuilding.ReligiousField] = new ReligiousField().cost,
        [landBuilding.Workshop] = new Workshop().cost,
        [landBuilding.Factory] = new Factory().cost,
        [landBuilding.Harbor] = new Harbor().cost,
        [landBuilding.University] = new University().cost

    };

    //development
    public static Dictionary<resource, int> Undeveloped = new Dictionary<resource, int>()
    {
        [resource.water] = 0,
        [resource.food] = 0,
        [resource.mineral] = 0,
        [resource.material] = 0,
        [resource.money] = 0,
        [resource.labor] = 0,
        [resource.product] = 0,

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
        [resource.food] = -1,
        [resource.mineral] = 0,
        [resource.material] = -1,
        [resource.money] = 1,
        [resource.labor] = 1,
        [resource.product] = 1,

    };

    public static Dictionary<resource, int> IndustrialArea = new Dictionary<resource, int>()
    {
        [resource.water] = -1,
        [resource.food] = -1,
        [resource.mineral] = -1,
        [resource.material] = -1,
        [resource.money] = 2,
        [resource.labor] = 0,
        [resource.product] = 2,

    };

    public static Dictionary<landDevelopment, Dictionary<resource, int>> allDevelopment = new Dictionary<landDevelopment, Dictionary<resource, int>>()
    {
        [landDevelopment.Undeveloped] = Undeveloped,
        [landDevelopment.Village] = Village,
        [landDevelopment.Town] = Town,
        [landDevelopment.City] = City,
        [landDevelopment.IndustrialArea] = IndustrialArea,
    };
}


