using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerPanel : MonoBehaviour
{
    protected Player player;
    //[SerializeField]
    //protected GameObject showThisPanel;
    //[SerializeField]
    //protected GameObject hideThisPanel;
    [SerializeField]
    protected Text water;
    [SerializeField]
    protected Text food;
    [SerializeField]
    protected Text mineral;
    [SerializeField]
    protected Text material;
    [SerializeField]
    protected Text money;
    [SerializeField]
    protected Text labor;
    [SerializeField]
    protected Text product;

    // Start is called before the first frame update
    protected void Start()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
    }

    // Update is called once per frame
    protected void Update()
    {
        ReadDictionary();

    }
    public virtual void ReadDictionary()
    {

    }

}
