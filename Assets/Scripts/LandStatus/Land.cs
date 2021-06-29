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
    
    public Development development;//�g�a�}�o���A
    public List<landBuilding> buildings;//�g�a�W���ؿv
    public int buildingsCount;
    public Dictionary<resource, int> resources;//�C�^�X�g�a���귽�ܤ�

    private Development developmentTree;//�g�a���A�t�i����

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
    void OnMouseDown()//�I���g�a
    {
        landStatusUI.gameObject.SetActive(true);
        landStatusUI.LoadLandInfo(this);
    }

    public Dictionary<resource, int> Preview(landBuilding buildingName)//�سy�ؿv���w��
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

    public Dictionary<resource, int> PreviewDevelop(landDevelopment developName)//�}�o�g�a�w��
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

    public virtual void Build(Dictionary<resource, int> next,landBuilding building)//�سy
    {
    }
    public virtual void Develop(Dictionary<resource, int> next)//�}�o
    {
        resources = next;
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

    public void SetDevelopment(landDevelopment target)//�N�g�a�]�w�����w���}�o���A
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
