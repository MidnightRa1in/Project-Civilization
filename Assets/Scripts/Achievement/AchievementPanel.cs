using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AchievementPanel : MonoBehaviour
{
    [SerializeField]
    private Slider progressBar;//bar used in contentPanel
    [SerializeField]
    private Text elementName;
    [SerializeField]
    private Text amount;
    [SerializeField]
    private Image fill;
 

    public Gradient gradient;

    // Start is called before the first frame update
    
    public void SetProgress(string name,int max, int now)
    {
        elementName.text = name;
        amount.text = now + " / " + max;
        progressBar.maxValue = max;
        progressBar.value = now;
        fill.color = gradient.Evaluate(progressBar.normalizedValue);
    }

}
