using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AchievementButton : MonoBehaviour
{
    [SerializeField]
    private Text buttonName;
    [SerializeField]
    private AchievementUI UI;

    private Achievement achievement;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetText(Achievement act)
    {
        buttonName.text = act.AchievementName.ToString();
        achievement = act;
    }
    public void buttonClicked()
    {
        UI.GenerateAchievementContents(achievement);
    }
}
