using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public static Input_Manager InputManager { get; private set; }

    public UIManager UIManager { get; private set; }

    public Menu_Controller MenuController;

    private static float secondsSinceStart = 0;
    private static int score;
    public static int LapCount = 0;
    private static string EndTime;
    private static string Result;
    public static bool LapMade;
    public static int TotalLap = 1;

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
        InputManager = this.GetOrAddComponent<Input_Manager>();
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
        Menu_Controller.Is_Game_Paused = false;
        Time.timeScale = 1f;

    }

    public static void ResetScore()
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
            Instance.UIManager.UpdateLapNumUI(LapCount, TotalLap);
        }
    }

    public static void LapMidway()
    {
        LapMade = true;
    }

    public static void Final_Results()
    {
        Result = score.ToString();
        EndTime = System.TimeSpan.FromSeconds(secondsSinceStart).ToString("hh':'mm':'ss");
    }

    public static string Final_Result()
    {
        return Result;
    }

    public static string Final_Time()
    {
        return EndTime;
        
    }
}