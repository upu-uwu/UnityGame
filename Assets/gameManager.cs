using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    int coinCollect = 0;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI timerText;

    public GameObject winPannel;
    public GameObject lossPannel;


    public float timer = 45;

    public void coinAdd()
    {
        coinCollect++;
        Debug.Log(coinCollect);
        scoreText.text = "Coin: " + coinCollect;
    }
    public void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
            TimeSpan timerData = TimeSpan.FromSeconds(timer);
            timerText.text = "Timer: " + timerData.Seconds;

            if (coinCollect == 3)
            {
                winPannel.SetActive(true);
                Time.timeScale = 0.7f;
            }
        }
        else
        {
            lossPannel.SetActive(true);
            Time.timeScale = 0.7f;
        }
    }
   
}