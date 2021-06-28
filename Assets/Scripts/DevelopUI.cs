using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DevelopUI : MonoBehaviour
{
    [SerializeField]
    private GameObject nextStageButton;
    [SerializeField]
    private GameObject previewPanel;

    private Player player;
    private List<GameObject> buttons;
    private List<GameObject> resourcePanel;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
        buttons = new List<GameObject>();
        resourcePanel = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Activated()//產生預覽下一狀態按鈕
    {
        player = GameObject.Find("Player").GetComponent<Player>();
        if (buttons.Count > 0)
        {
            foreach (GameObject button in buttons)
            {
                Destroy(button.gameObject);
            }
            buttons.Clear();
        }
        if (resourcePanel.Count > 0)
        {
            foreach (GameObject panel in resourcePanel)
            {
                Destroy(panel.gameObject);
            }
            resourcePanel.Clear();
        }

        for (int i = 0; i < player.locationNow.development.nextDevelopment.Count; i++)
        {
            GameObject button = Instantiate(nextStageButton) as GameObject;
            button.SetActive(true);
            button.GetComponent<NextStageButton>().SetText(player.locationNow.development.nextDevelopment[i].stage);

            Debug.Log(player.locationNow.development.stage + "now");
            Debug.Log(player.locationNow.development.nextDevelopment[i].stage + "next");

            button.transform.SetParent(nextStageButton.transform.parent, false);
            buttons.Add(button);
        }
    }
    public void GeneratePreviewPanel(Dictionary<resource, int> previewRes, Dictionary<resource, int> change)//產生預覽畫面
    {
        if (resourcePanel.Count > 0)
        {
            foreach (GameObject panel in resourcePanel)
            {
                Destroy(panel.gameObject);
            }
            resourcePanel.Clear();
        }

        foreach (KeyValuePair<resource, int> resource in previewRes)
        {
            GameObject panel = Instantiate(previewPanel) as GameObject;
            panel.SetActive(true);
            panel.GetComponent<PreviewPanel>().SetText(resource.Key.ToString(), resource.Value.ToString());
            panel.transform.SetParent(previewPanel.transform.parent, false);
            resourcePanel.Add(panel);
        }

    }
}
