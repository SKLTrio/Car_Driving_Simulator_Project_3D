using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Menu_Controller : MonoBehaviour
{
    [SerializeField]
    public string Start_Menu_Scene;

    [SerializeField]
    public string Game_Scene;

    [SerializeField]
    public GameObject High_Score_Panel;

    [SerializeField]
    public GameObject Start_Controls_Panel;

    [SerializeField]
    public GameObject Start_Car_Colour_Panel;

    [SerializeField]
    public GameObject Pause_Panel;

    [SerializeField]
    public GameObject Victory_Panel;

    [SerializeField]
    bool Is_Pause_Menu_Available = false;

    [HideInInspector]
    public static bool Is_Game_Paused = false;

    public Car_Colour_Changer Car_Colour_Changer_Script;

    void Update()
    {
        Pause_Menu();
    }

    public void Pause_Menu()
    {
        if (Is_Pause_Menu_Available)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                if (Is_Game_Paused)
                {
                    Resume();
                }

                else
                {
                    Pause();
                }
            }
        }
    }

    void Pause()
    {
        Cursor.visible = true;
        Pause_Panel.SetActive(true);
        Time.timeScale = 0f;
        Is_Game_Paused = true;

    }

    public void Resume()
    {
        Cursor.visible = false;
        Pause_Panel.SetActive(false);
        Time.timeScale = 1f;
        Is_Game_Paused = false;
    }

    public void Return_To_Main_Menu()
    {
        Resume();
        Cursor.visible = true;
        SceneManager.LoadScene(Start_Menu_Scene);
    }

    public void Start_Game()
    {
        Cursor.visible = false;
        SceneManager.LoadScene(Game_Scene);

    }

    public void Quit_Game()
    {
        Debug.Log("You have quit the game!");
        Application.Quit();

        Car_Colour_Changer_Script.ResetCarColor();
    }

    public void Start_High_Score_Menu_Open()
    {
        High_Score_Panel.SetActive(true);
    }

    public void Start_High_Score_Menu_Close()
    {
        High_Score_Panel.SetActive(false);
    }

    public void Start_Controls_Menu_Open()
    {
        Start_Controls_Panel.SetActive(true);
    }

    public void Start_Controls_Menu_Close()
    {
        Start_Controls_Panel.SetActive(false);
    }

    public void Start_Car_Colour_Menu_Open()
    {
        Start_Car_Colour_Panel.SetActive(true);
    }

    public void Start_Car_Colour_Menu_Close()
    {
        Start_Car_Colour_Panel.SetActive(false);
    }
    public void SaveChosenColour(Color Chosen_Colour)
    {
        PlayerPrefs.SetString("Chosen_Colour", "#" + ColorUtility.ToHtmlStringRGB(Chosen_Colour));
        Debug.Log("Saved Colour Is:" + Chosen_Colour);
    }

    public void Congrats_Panel_Load()
    {
        Pause();
        Victory_Panel.SetActive(true);
    }

}
