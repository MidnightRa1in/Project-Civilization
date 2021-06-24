using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

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
//public enum landBuilding
//{
//    MineralFacility,
//    MaterialFacility,
//    FishingVillage,
//    Farm,
//    Market,
//    TradeCenter,
//    FinanceCenter,
//    ArtField,
//    ReligiousField,
//    Workshop,
//    Harbor,
//    University,
//}
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
    public List<string> landBuilding = new List<string>() {
        "MineralFacility",
        "MaterialFacility",
        "FishingVillage",
        "Farm",
        "Market",
        "TradeCenter",
        "FinanceCenter",
        "ArtField",
        "ReligiousField",
        "Workshop",
        "Harbor",
        "University",
    };
    public string landID;
    public Land[] nearbyLands;
    public string LandID
    {
        get { return landID.ToString(); }
    }
    public landStatus status;
    public landDevelopment development;
    public List<string> buildings;
    private SerializedObject landSerObj;
    private SerializedProperty landSerProp;
    public Dictionary<string, int> landResource;


    // Start is called before the first frame update
    void Start()
    {
        buildings = new List<string>();
        development = landDevelopment.Undeveloped;
        landResource = new Dictionary<string, int>(Resource.mountain);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Dictionary<string, int> Preview(string buildingName)
    {
        Dictionary<string, int> previewRes = new Dictionary<string, int>();
        foreach (var building in Resource.allBuilding[buildingName])
        {
            foreach(var land in landResource)
            {
                if (building.Value != 0 && land.Key == building.Key)
                {
                    previewRes.Add(building.Key, building.Value + land.Value);
                }
            }
            
        }
        return previewRes;

        //landSerObj = new UnityEditor.SerializedObject(resources);
        //landSerProp = landSerObj.GetIterator();
        

        //Resource newRes = ScriptableObject.CreateInstance<Resource>();
        //SerializedObject newSerObj = new UnityEditor.SerializedObject(newRes);
        //SerializedObject sourceSerObj = new UnityEditor.SerializedObject(sourceRes);

        //SerializedProperty newSerProp = newSerObj.GetIterator();
        //SerializedProperty sourceSerProp = sourceSerObj.GetIterator();

        //while (sourceSerProp.NextVisible(true))
        //{
        //    while (newSerProp.NextVisible(true))
        //    {

        //        if (newSerProp.name != "m_Script" && sourceSerProp.intValue != 0)
        //        {
        //            while (landSerProp.NextVisible(true))
        //            {
        //                if (sourceSerProp.name == newSerProp.name && sourceSerProp.name == landSerProp.name)
        //                {
        //                    newSerProp.intValue = landSerProp.intValue + sourceSerProp.intValue;
        //                    Debug.Log(newSerProp.intValue);

        //                }
        //            }
        //        }                                       

        //    }

        //}
            //landSerProp.NextVisible(true);
            //for(int i = 0; i < landSerProp.CountRemaining(); i++)
            //{
            //    if(sourceSerProp.GetArrayElementAtIndex(i).intValue != 0)
            //    {
            //        newSerProp.GetArrayElementAtIndex(i).intValue = landSerProp.GetArrayElementAtIndex(i).intValue + sourceSerProp.GetArrayElementAtIndex(i).intValue;
            //        Debug.Log(newSerProp.GetArrayElementAtIndex(i).intValue);
            //    }
            //}

    }

    

 

}
