using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public UIManager UIManager { get; private set; }

    private static float secondsSinceStart = 0;
    private static int score;
    private static double LapCount = -0.5;
    private static string EndTime;
    private static string Result;

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
        LapCount += 0.5;
        Instance.UIManager.UpdateLapNumUI(LapCount);
    }

    //public void GameOver(string sType)
    //{
    //    EndTime = System.TimeSpan.FromSeconds(secondsSinceStart).ToString("mm':'ss");
    //    Time.timeScale = 0f;
    //    MenuController.IsGamePaused = true;
    //    Debug.Log(EndTime);
    //    Result = sType;
    //    Debug.Log(Result);
    //    instance.UIManager.ActivateEndGame(score, sType);
    //    HighScoreSystem.CheckHighScore(score, EndTime, Result);
    //}
}
