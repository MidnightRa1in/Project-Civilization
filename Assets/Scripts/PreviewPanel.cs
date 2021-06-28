using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PreviewPanel : MonoBehaviour
{
    [SerializeField]
    private Text itemName;
    [SerializeField]
    private Text itemChange;
    [SerializeField]
    private Text itemChangeAmount;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetText(string _itemName, string _itemChange)
    {
        itemName.text = _itemName;
        itemChange.text = _itemChange;
    }
    public void SetText(string _itemName, string _itemChange, string _itemChangeAmount)
    {
        itemName.text = _itemName;
        itemChange.text = _itemChange;
        itemChangeAmount.text = "(" + _itemChangeAmount + ")";
    }
}
