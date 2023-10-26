using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public UIManager UIManager { get; private set; }

    public Menu_Controller MenuController;

    private static float secondsSinceStart = 0;
    private static int score;
    public static double LapCount = 0;
    private static string EndTime;
    private static string Result;
    public static bool LapMade;

    // Start is called before the first frame update
    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
            return;
        }
        
        Instance = this;
        
        UIManager = GetComponent<UIManager>();
        MenuController = GetComponent<Menu_Controller>();
    }

    // Update is called once per frame
    void Update()
    {
        secondsSinceStart += Time.deltaTime;
        Instance.UIManager.UpdateTimeUI(secondsSinceStart);
    }

    public static string GetScoreText()
    {
        return score.ToString();
    }

    public static void IncrementScore(int value)
    {
        score += value;
        Instance.UIManager.UpdateScoreUI(score);
        Debug.Log("Score: " + score);
    }

    public static void ResetGame()
    {
        ResetScore();
        secondsSinceStart = 0f;
    }

    private static void ResetScore()
    {
        score = 0;
        Instance.UIManager.UpdateScoreUI(score);
        Debug.Log("Score: " + score);
    }

    public static void LapCounter()
    {
        if (LapMade == true)
        {
            LapCount += 1;
            Instance.UIManager.UpdateLapNumUI(LapCount);
        }
    }

    public static void LapMidway()
    {
        LapMade = true;
    }
}