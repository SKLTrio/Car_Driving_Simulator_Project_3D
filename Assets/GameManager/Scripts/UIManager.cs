using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI timeValue;
    [SerializeField]
    TextMeshProUGUI scoreValue;
    
    void Start()
    {
        UpdateTimeUI(0);
        UpdateScoreUI(0);
    }

    public void UpdateTimeUI(float time)
    {
        int seconds = (int)time;
        timeValue.text = System.TimeSpan.FromSeconds(seconds).ToString("hh':'mm':'ss");
    }

    public void UpdateScoreUI(int value)
    {
        // "D5" - minimum of 5 digits, preceding shorter numbers with 0s
        scoreValue.text = value.ToString("D5");
    }    
}
