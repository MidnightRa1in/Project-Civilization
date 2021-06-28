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


    // Start is called before the first frame update
    void Start()
    {        
        transform.position = Athena11AsSpawn.transform.position;
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
            [resource.labor] = 1,
            [resource.product] = 2,

        };
        ClearResource();
        
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

    
    


    
}
