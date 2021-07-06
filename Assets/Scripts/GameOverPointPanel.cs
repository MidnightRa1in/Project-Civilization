using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverPointPanel : MonoBehaviour
{
    [SerializeField]
    private Text achievementName;
    [SerializeField]
    private Text achievementPoints;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetText(Achievement ach, int point)
    {
        achievementName.text = ach.AchievementName.ToString();
        achievementPoints.text = point.ToString();
    }
}
