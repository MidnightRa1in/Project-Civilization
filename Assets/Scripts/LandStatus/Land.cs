using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using System;

//Land、Building、Development種類
public enum landStatus
{
    Volcano,
    Desert,
    Forest,
    Lake,
    Riverside,
    Plateau,
    Plain,
    Island,
    Seashore,
    Swamp,
    Savanna,
    Mountain,
}
public enum landBuilding
{
    MineralFacility,
    MaterialFacility,
    FishingVillage,
    Farm,
    Market,
    FinanceCenter,
    ArtField,
    ReligiousField,
    Workshop,
    Factory,
    Harbor,
    University,
}
public enum landDevelopment
{
    Undeveloped,
    Village,
    Town,
    City,
    IndustrialArea,
}

public enum resource
{
    water,
    food,
    mineral,
    material,
    money,
    labor,
    product,
}
public class Land : MonoBehaviour
{
    public string landID;
    public Land[] nearbyLands;
    public landStatus status;
    
    public Development development;//土地開發狀態
    public List<landBuilding> buildings;//土地上的建築
    public int buildingsCount;
    public Dictionary<resource, int> resources;//每回合土地的資源變化

    private Development developmentTree;//土地狀態演進順序

    public LandStatusUI landStatusUI;

    // Start is called before the first frame update
    public void Start()
    {
        buildings = new List<landBuilding>(3);
        buildingsCount = 0;
        development = InitialTree();
    }

    // Update is called once per frame
    public void Update()
    {
        
    }
    void OnMouseDown()//點擊土地
    {
        landStatusUI.gameObject.SetActive(true);
        landStatusUI.LoadLandInfo(this);
    }

    public Dictionary<resource, int> Preview(landBuilding buildingName)//建造建築物預覽
    {
        Dictionary<resource, int> previewRes = new Dictionary<resource, int>();
        foreach (KeyValuePair<resource, int> building in Resource.allBuilding[buildingName])
        {
            foreach(KeyValuePair<resource, int> land in resources)
            {
                               
                if (land.Key == building.Key)
                {
                    previewRes.Add(building.Key, building.Value + land.Value);
                }
            }
            
        }
        
        return previewRes;

    }

    public Dictionary<resource, int> PreviewDevelop(landDevelopment developName)//開發土地預覽
    {
        Dictionary<resource, int> previewRes = new Dictionary<resource, int>();
        foreach (KeyValuePair<resource, int> resource in Resource.allDevelopment[developName])
        {
            foreach (KeyValuePair<resource, int> land in resources)
            {
                if (land.Key == resource.Key)
                {
                    previewRes.Add(resource.Key, resource.Value + land.Value);
                }
            }
        }
        return previewRes;
    }

    public virtual void Build(Dictionary<resource, int> next,landBuilding building)//建造
    {
    }
    public virtual void Develop(Dictionary<resource, int> next)//開發
    {
        resources = next;
    }

    //public virtual void OccurEvent()
    //{

    //}
    private void SetNextStage(landDevelopment[] stage)//設定土地演進的下一個階段
    {
        Development setTothis = new Development();
        setTothis = developmentTree;

        while (setTothis.nextDevelopment.Count != 0)
        {
            setTothis = setTothis.nextDevelopment[0];
        }
        for (int i = 0; i < stage.Length; i++)
        {
            Development newDev = new Development(stage[i]);
            setTothis.nextDevelopment.Add(newDev);
        }

    }
    public Development InitialTree()//土地狀態演進的資料結構
    {
        developmentTree = new Development(landDevelopment.Undeveloped);
        SetNextStage(new landDevelopment[] { landDevelopment.Village });
        SetNextStage(new landDevelopment[] { landDevelopment.Town });
        SetNextStage(new landDevelopment[] { landDevelopment.City, landDevelopment.IndustrialArea });
        return developmentTree;
    }

    public void SetDevelopment(landDevelopment target)//將土地設定為指定的開發狀態
    {
        foreach(Development nextOne in development.nextDevelopment)
        {
            if(nextOne.stage == target)
            {
                development = nextOne;
            }
        }
    }









}
