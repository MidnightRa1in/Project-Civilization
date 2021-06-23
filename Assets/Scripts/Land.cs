using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
public class Land : MonoBehaviour
{

    public string landID;
    public Land[] nearbyLands;
    public string LandID
    {
        get { return landID.ToString(); }
    }
    public landStatus status;
    public landDevelopment development;
    public landBuilding[] buildings;
    public Resource resources;

    
    // Start is called before the first frame update
    void Start()
    {
        buildings = new landBuilding[3];
        development = landDevelopment.Undeveloped;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

 

}
