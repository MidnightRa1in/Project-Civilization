using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using System;

//Land�BBuilding�BDevelopment����
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
    Cave,
}
public enum landBuilding
{
    MineralFacility,
    MaterialFacility,
    FishingVillage,
    Farm,
    Market,
    TradeCenter,
    FinanceCenter,
    ArtField,
    ReligiousField,
    Workshop,
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

    development,

}
public class Land : MonoBehaviour
{
    //public List<string> landBuildings = new List<string>() {
    //    "MineralFacility",
    //    "MaterialFacility",
    //    "FishingVillage",
    //    "Farm",
    //    "Market",
    //    "TradeCenter",
    //    "FinanceCenter",
    //    "ArtField",
    //    "ReligiousField",
    //    "Workshop",
    //    "Harbor",
    //    "University",
    //};
    public string landID;
    public Land[] nearbyLands;
    public landStatus status;
    
    public Development development;//�g�a�}�o���A
    public List<landBuilding> buildings;//�g�a�W���ؿv
    public int buildingsCount;
    public Dictionary<resource, int> landResource;//�C�^�X�g�a���귽�ܤ�

    private Development developmentTree;//�g�a���A�t�i����

    // Start is called before the first frame update
    public void Start()
    {
        buildings = new List<landBuilding>(3);
        buildingsCount = 0;
        development = InitialTree();
        landResource = new Dictionary<resource, int>(Mountain.resources);
    }

    // Update is called once per frame
    public void Update()
    {
        
    }

    public Dictionary<resource, int> Preview(string buildingName)//�سy�ؿv���w��
    {
        Dictionary<resource, int> previewRes = new Dictionary<resource, int>();
        foreach (var building in Resource.allBuilding[buildingName])
        {
            foreach(var land in landResource)
            {
                               
                if (land.Key == building.Key)
                {
                    previewRes.Add(building.Key, building.Value + land.Value);
                }
            }
            
        }
        
        return previewRes;

    }

    public Dictionary<resource, int> PreviewDevelop(landDevelopment developName)//�}�o�g�a�w��
    {
        Dictionary<resource, int> previewRes = new Dictionary<resource, int>();
        foreach (var resource in Resource.allDevelopment[developName])
        {
            foreach (var land in landResource)
            {
                if (land.Key == resource.Key)
                {
                    previewRes.Add(resource.Key, resource.Value + land.Value);
                }
            }
        }
        return previewRes;
    }

    public virtual void Build(Dictionary<resource, int> next)//�سy
    {
        landResource = next;
    }

    //public virtual void OccurEvent()
    //{

    //}
    private void SetNextStage(landDevelopment[] stage)//�]�w�g�a�t�i���U�@�Ӷ��q
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
    public Development InitialTree()//�g�a���A�t�i����Ƶ��c
    {
        developmentTree = new Development(landDevelopment.Undeveloped);
        SetNextStage(new landDevelopment[] { landDevelopment.Village });
        SetNextStage(new landDevelopment[] { landDevelopment.Town });
        SetNextStage(new landDevelopment[] { landDevelopment.City, landDevelopment.IndustrialArea });
        return developmentTree;
    }

    public void SetDevelopment(landDevelopment target)
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
