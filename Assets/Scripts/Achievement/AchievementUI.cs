using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AchievementUI : MonoBehaviour
{
    [SerializeField]
    private Button closeButton;
    [SerializeField]
    private AchievementGenreButton generalAchievementButton;
    [SerializeField]
    private AchievementGenreButton resourceAchievementButton;
    [SerializeField]
    private AchievementGenreButton landAchievementButton;
    [SerializeField]
    private Text achievementShowingNow;

    [SerializeField]
    private GameObject achievements;//achievement button
    [SerializeField]
    private GameObject achievementConents;//panel


    private Player player;

    private List<GameObject> buttons;
    private List<GameObject> panels;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
        player = GameObject.Find("Player").GetComponent<Player>();
        buttons = new List<GameObject>();
        panels = new List<GameObject>();
    }


    public void Activated()
    {
        clearList(buttons);
        clearList(panels);
    }
    public void GenerateAchievementButton(List<Achievement> list)
    {
        clearList(buttons);
        foreach (Achievement ach in list)
        {
            GameObject button = Instantiate(achievements) as GameObject;
            button.SetActive(true);
            button.GetComponent<AchievementButton>().SetText(ach);
            button.transform.SetParent(achievements.transform.parent, false);
            buttons.Add(button);
        }
    }

    public void GenerateAchievementContents(Achievement ach)
    {
        clearList(panels);
        achievementShowingNow.text = ach.AchievementName.ToString();
        foreach (KeyValuePair<landBuilding,int> build in ach.BuildingReq)
        {
            GameObject panel = Instantiate(achievementConents) as GameObject;
            panel.SetActive(true);
            panel.GetComponent<AchievementPanel>().SetProgress(build.Key.ToString(),build.Value, player.PlayerBuilings[build.Key]);
            panel.transform.SetParent(achievementConents.transform.parent, false);
            panels.Add(panel);
        }
        foreach (KeyValuePair<landDevelopment, int> develop in ach.DevelopReq)
        {
            GameObject panel = Instantiate(achievementConents) as GameObject;
            panel.SetActive(true);
            panel.GetComponent<AchievementPanel>().SetProgress(develop.Key.ToString(), develop.Value, player.PlayerDevelopments[develop.Key]);
            panel.transform.SetParent(achievementConents.transform.parent, false);
            panels.Add(panel);
        }
        foreach (KeyValuePair<resource, int> res in ach.ResourceReq)
        {
            GameObject panel = Instantiate(achievementConents) as GameObject;
            panel.SetActive(true);
            panel.GetComponent<AchievementPanel>().SetProgress(res.Key.ToString(), res.Value, player.Property[res.Key]);
            panel.transform.SetParent(achievementConents.transform.parent, false);
            panels.Add(panel);
        }
        foreach (KeyValuePair<landStatus, int> status in ach.StatusReq)
        {
            GameObject panel = Instantiate(achievementConents) as GameObject;
            panel.SetActive(true);
            panel.GetComponent<AchievementPanel>().SetProgress(status.Key.ToString(), status.Value, player.PlayerLandStatus[status.Key]);
            panel.transform.SetParent(achievementConents.transform.parent, false);
            panels.Add(panel);
        }
    }
    public void clearList(List<GameObject> list)
    {
        if (list.Count > 0)
        {
            foreach (GameObject button in list)
            {
                Destroy(button.gameObject);
            }
            list.Clear();
        }      
    }
}
