using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Resource Asset", menuName = "Resource Asset")]
public class Resource : ScriptableObject
{
    public int Water;
    public int Food;
    public int Mineral;
    public int Material;
    public int Money;
    public int Labor;
    public int Product;


    public int WaterConsumption;
    public int FoodConsumption;
    public int MineralConsumption;
    public int MaterialConsumption;
    public int MoneyConsumption;
    public int LaborConsumption;
    public int ProductConsumption;

    public int Development;
}
