using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // ---------------------------
    // Variables
    // ---------------------------

    [Header("Timer and Score")]
    [SerializeField] TextMeshProUGUI timeText;
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] UnityEvent timerEnd;

    [Header("Components")]
    [SerializeField] Game game;



    // ---------------------------
    // Functions
    // ---------------------------

    void Start()
    {
        game.activateTimer = true;
    }

    void Update()
    {
        Timer();
    }

    public void UpdateScore()
    {
        scoreText.text = game.scores + " points";
    }

    void Timer()
    {
        if(game.activateTimer)
        {
            if(game.currentTime > 0)
            {
                game.currentTime -= Time.deltaTime;
                if(game.currentTime <= 0) game.currentTime = 0;
                ShowTime();
            }

            else
            {
                game.currentTime = 0;
                game.activateTimer = false;
                timerEnd.Invoke();
            }
        }
    }

       void ShowTime()
    {
        float time = game.currentTime;

        // Convert Float to Seconds
        TimeSpan ts = TimeSpan.FromSeconds(time);
        timeText.text = string.Format("{0:00}:{1:00}", ts.Minutes, ts.Seconds);
    }
}
