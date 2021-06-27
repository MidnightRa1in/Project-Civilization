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
    private List<Land> developedLands; //�w�}�o���g�a
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
        property = new Dictionary<resource, int>()
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
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddALand(Land newLand)
    {
        developedLands.Add(newLand);
    }
    private void ClearResource()//�M��
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

    public void CountResource()//�p���ܤƶq
    {
        Dictionary<resource, int> temp = new Dictionary<resource, int>();
        ClearResource();
        foreach (Land land in developedLands)
        {
            foreach (var resource in resourceEachTurn)
            {
                foreach (var landResource in land.landResource)
                {
                    if (resource.Key == landResource.Key)
                    {
                        temp.Add(resource.Key, resource.Value + landResource.Value);
                    }
                }
            }
        }
        resourceEachTurn = temp;
    }
    public void GetResource()
    {
        Dictionary<resource, int> temp = new Dictionary<resource, int>();
        foreach(var prop in property)
        {
            foreach(var eachTurn in resourceEachTurn)
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
