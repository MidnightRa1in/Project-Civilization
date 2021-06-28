using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConfirmButton : MonoBehaviour
{
    [SerializeField]
    protected Player player;


    protected Dictionary<resource, int> next = new Dictionary<resource, int>();
    protected landDevelopment nextStage;
    protected landBuilding constructedBuilding;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public virtual void buttonClicked()
    {
        
    }
    public void loadNext(Dictionary<resource, int> next)
    {
        this.next = next;
    }

    public void loadNextStage(landDevelopment next)
    {
        nextStage = next;
    }

    public void loadConstructedBuilding(landBuilding newOne)
    {
        constructedBuilding = newOne;
    }
}
