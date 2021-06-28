using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NextStageButton : MonoBehaviour
{
    [SerializeField]
    private Text buttonName;
    [SerializeField]
    private DevelopUI developUI;
    [SerializeField]
    private ConfirmButton confirm;
    private Player player;

    private landDevelopment developName;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<Player>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetText(landDevelopment res)
    {
        buttonName.text = res.ToString();
        developName = res;        
    }

    public void developmentClicked()
    {
        Dictionary<resource, int> next = new Dictionary<resource, int>();
        Dictionary<resource, int> change = new Dictionary<resource, int>(); 
        change =  Counting(next);
        next = player.locationNow.PreviewDevelop(developName);
        developUI.GeneratePreviewPanel(next,change);
        confirm.loadNext(next);
        confirm.loadNextStage(developName);
        Debug.Log(developName);

    }
    private Dictionary<resource, int> Counting(Dictionary<resource, int> next)
    {
        Dictionary<resource, int> previewRes = new Dictionary<resource, int>();
        foreach (KeyValuePair<resource, int> resource in Resource.allDevelopment[player.locationNow.development.stage])
        {
            foreach (KeyValuePair<resource, int> nextOne in next)
            {
                if (nextOne.Key == resource.Key)
                {
                    previewRes.Add(resource.Key, nextOne.Value - resource.Value);
                }
            }
        }
        return previewRes;
    }
}
