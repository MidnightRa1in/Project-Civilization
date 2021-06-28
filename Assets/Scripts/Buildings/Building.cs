using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building
{
    public  Dictionary<resource, int> resources;
    public  Dictionary<resource, int> cost;
    protected landBuilding buildingName;
    protected List<landStatus> canBuildOn;
    protected List<landDevelopment> canNotBuildOn;
    protected int turnLimit = 0;
    public landBuilding BuildingName
    {
        get { return buildingName; }
    }    
    public Building()
    {

    }
    public virtual bool CheckBuildingAllowance(Land land)
    {
        bool buildingAllowed = false;
        foreach (landStatus status in canBuildOn)
        {
            if (status == land.status)
            {
                buildingAllowed = true;
                break;
            }
        }
        foreach (landDevelopment dev in canNotBuildOn)
        {
            if (dev == land.development.stage)
            {
                buildingAllowed = false;
                break;
            }
        }
        if (GameControl.rounds < turnLimit) buildingAllowed = false;
        return buildingAllowed;
    }
}
