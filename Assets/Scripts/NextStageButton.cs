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
        next = player.locationNow.PreviewDevelop(developName);
        developUI.GeneratePreviewPanel(next);
        confirm.loadNext(next);
        confirm.loadNextStage(developName);
        Debug.Log(developName);

    }
}
