using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class BuildUI : MonoBehaviour
{
    [SerializeField]
    private GameObject previewButton;
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
    public void Activated()
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

        Array buildings = Enum.GetValues(typeof(landBuilding));

        foreach(landBuilding build in buildings)
        {
            GameObject button = Instantiate(previewButton) as GameObject;
            button.SetActive(true);
            button.GetComponent<PreviewButton>().SetText(build);
            button.transform.SetParent(previewButton.transform.parent, false);
            buttons.Add(button);
        }
    }
    public void GeneratePreviewPanel(Dictionary<resource, int> previewRes)
    {
        if (resourcePanel.Count > 0)
        {
            foreach (GameObject panel in resourcePanel)
            {
                Destroy(panel.gameObject);
            }
            resourcePanel.Clear();
        }

        foreach(var resource in previewRes)
        {
            GameObject panel = Instantiate(previewPanel) as GameObject;
            panel.SetActive(true);
            panel.GetComponent<PreviewPanel>().SetText(resource.Key.ToString(),resource.Value.ToString());
            panel.transform.SetParent(previewPanel.transform.parent, false);
            resourcePanel.Add(panel);
        }

    }


}
