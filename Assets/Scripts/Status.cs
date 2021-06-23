using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Status : ScriptableObject
{
    public enum Development
    {
        Village,
        Town,
        City,
        IndustrialArea,
    }

    public enum Building
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
    public enum LandStatus
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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
