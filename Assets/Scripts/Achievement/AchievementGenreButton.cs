using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AchievementGenreButton : MonoBehaviour
{
    [SerializeField]
    protected AchievementUI UI;
    protected List<Achievement> achievements;

    public void buttonClicked()
    {
        UI.GenerateAchievementButton(achievements);
    }
}
