using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool moveAllowed;
    //public bool developAllowed;
    public Land locationNow;
    [SerializeField]
    private Land Athena11AsSpawn;
    //ublic Land[] lands;
    private List<Land> developedLands; //已開發的土地
    public List<Land> DevelopedLands
    {
        get { return developedLands; }
    }
    private Dictionary<landBuilding, int> playerBuilings;
    private Dictionary<landDevelopment, int> playerDevelopments;
    private Dictionary<landStatus, int> playerLandStatus;
    private Dictionary<resource, int> property;
    private Dictionary<resource, int> resourceEachTurn;
    public Dictionary<resource, int> Property
    {
        get { return property; }
    }
    public Dictionary<resource, int> ResourceEachTurn
    {
        get { return resourceEachTurn; }
    }
    public Dictionary<landBuilding, int> PlayerBuilings
    {
        get { return playerBuilings; }
    }
    public Dictionary<landDevelopment, int> PlayerDevelopments
    {
        get { return playerDevelopments; }
    }
    public Dictionary<landStatus, int> PlayerLandStatus
    {
        get { return playerLandStatus; }
    }


    // Start is called before the first frame update
    void Start()
    {        
        transform.position = Athena11AsSpawn.transform.position + new Vector3(0f,6f,0f);
        moveAllowed = false;
        locationNow = Athena11AsSpawn;
        developedLands = new List<Land>();
        property = new Dictionary<resource, int>()//初始值
        {
            [resource.water] = 5,
            [resource.food] = 5,
            [resource.mineral] = 0,
            [resource.material] = 5,
            [resource.money] = 0,
            [resource.labor] = 2,
            [resource.product] = 2,

        };
        ClearPlayerBuildings();
        ClearPlyerDevelopments();
        ClearResource();
        ClearPlayerLandStatus();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddALand(Land newLand)
    {
        developedLands.Add(newLand);
    }

    public void UseResource(landBuilding buildingCost)
    {
        Dictionary<resource, int> temp = new Dictionary<resource, int>();
        foreach(KeyValuePair<resource, int> prop in property)
        {
            foreach(KeyValuePair<resource, int> cost in Resource.allBuildingCost[buildingCost])
            {
                if(prop.Key == cost.Key)
                {
                    temp.Add(prop.Key, prop.Value - cost.Value);
                }
            }
        }
        property = temp;
    }
    public void UseResource(landDevelopment developCost)
    {
        Dictionary<resource, int> temp = new Dictionary<resource, int>();
        foreach (KeyValuePair<resource, int> prop in property)
        {
            foreach (KeyValuePair<resource, int> cost in Resource.allDevelopmentCost[developCost])
            {
                if (prop.Key == cost.Key)
                {
                    temp.Add(prop.Key, prop.Value - cost.Value);
                }
            }
        }
        property = temp;
    }

    public void Inventory()//得到build及develop總值
    {
        ClearPlayerBuildings();
        ClearPlyerDevelopments();
        ClearPlayerLandStatus();
        foreach (Land land in developedLands)
        {
            foreach(landBuilding build in land.buildings)
            {
                playerBuilings[build] += 1;
            }
            playerDevelopments[land.development.stage] += 1;
            playerLandStatus[land.status] += 1;
        }
    }
    private void ClearResource()//清空
    {
        resourceEachTurn = new Dictionary<resource, int>()
        {
            [resource.water] = 0,
            [resource.food] = 0,
            [resource.mineral] = 0,
            [resource.material] = 0,
            [resource.money] = 0,
            [resource.labor] = 0,
            [resource.product] = 0,

        };
    }

    public void CountResource()//計算變化量
    {
        Dictionary<resource, int> temp = new Dictionary<resource, int>()
        {
            [resource.water] = 0,
            [resource.food] = 0,
            [resource.mineral] = 0,
            [resource.material] = 0,
            [resource.money] = 0,
            [resource.labor] = 0,
            [resource.product] = 0,
        };
        ClearResource();
        foreach (Land land in developedLands)
        {
            foreach (KeyValuePair<resource, int> resource in resourceEachTurn)
            {
                foreach (KeyValuePair<resource, int> landResource in land.resources)
                {
                    if (resource.Key == landResource.Key)
                    {
                        temp[resource.Key] += (resource.Value + landResource.Value);
                    }
                }
            }
        }
        resourceEachTurn = temp;
    }
    public void GetResource()
    {
        Dictionary<resource, int> temp = new Dictionary<resource, int>();
        foreach(KeyValuePair<resource, int> prop in property)
        {
            foreach(KeyValuePair<resource, int> eachTurn in resourceEachTurn)
            {
                if(prop.Key == eachTurn.Key)
                {
                    temp.Add(prop.Key,prop.Value + eachTurn.Value);
                }
            }
        }
        property = temp;
    }

    private void ClearPlayerBuildings()
    {
        playerBuilings = new Dictionary<landBuilding, int>()
        {
            [landBuilding.MineralFacility] = 0,
            [landBuilding.MaterialFacility] = 0,
            [landBuilding.FishingVillage] = 0,
            [landBuilding.Farm] = 0,
            [landBuilding.Market] = 0,
            [landBuilding.FinanceCenter] = 0,
            [landBuilding.ArtField] = 0,
            [landBuilding.ReligiousField] = 0,
            [landBuilding.Workshop] = 0,
            [landBuilding.Factory] = 0,
            [landBuilding.Harbor] = 0,
            [landBuilding.University] = 0
        };
    }
    private void ClearPlyerDevelopments()
    {
        playerDevelopments = new Dictionary<landDevelopment, int>()
        {
            [landDevelopment.Undeveloped] = 0,
            [landDevelopment.Village] = 0,
            [landDevelopment.Town] = 0,
            [landDevelopment.City] = 0,
            [landDevelopment.IndustrialArea] = 0
        };
    }
    private void ClearPlayerLandStatus()
    {
        playerLandStatus = new Dictionary<landStatus, int>()
        {
            [landStatus.Volcano] = 0,
            [landStatus.Desert] = 0,
            [landStatus.Forest] = 0,
            [landStatus.Lake] = 0,
            [landStatus.Riverside] = 0,
            [landStatus.Plateau] = 0,
            [landStatus.Plain] = 0,
            [landStatus.Island] = 0,
            [landStatus.Seashore] = 0,
            [landStatus.Swamp] = 0,
            [landStatus.Savanna] = 0,
            [landStatus.Mountain] = 0,
        };
    }

    
    


    
}
