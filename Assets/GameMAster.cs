using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameMAster : MonoBehaviour
{
    public static bool pause;

    public GameObject PauseMenuUI;
    public GameObject Ganas;
    public GameObject Pierdes;

    public Text Counter;
    public float seconds, minutes;

    public GameObject TimePass;


    void Start ()
    {
        Victoria.Winner = false;
        Derrota.Loser = false;
        TimePass.SetActive(true);
        seconds = 0.0f;
        minutes = 0.0f;
    }

    void Update()
    {
        TimeCounter();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (pause)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            Restart();
        }

        if (Victoria.Winner == true)
        {
            Ganas.SetActive(true);
            if (Input.GetKeyDown(KeyCode.M))
            {
                Menu();
            }
            TimePass.SetActive(false);
        }

        if (Derrota.Loser == true)
        {
            Pierdes.SetActive(true);
            if (Input.GetKeyDown(KeyCode.M))
            {
                Menu();
            }
            TimePass.SetActive(false);
        }
    }

    public void Pause()
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0;
        pause = true;
    }

    public void Resume()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1;
        pause = false;
    }

    public void Menu()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1;
        pause = false;
    }

    public void Restart()
    {
        SceneManager.LoadScene("Gameplay");
        Time.timeScale = 1;
        pause = false;
    }

    void TimeCounter()
    {
        minutes = (int)(Time.time/60f);
        seconds = (int)(Time.time % 60f);
        Counter.text = minutes.ToString("00") + ":" + seconds.ToString("00");
    }
}