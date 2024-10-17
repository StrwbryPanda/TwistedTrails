using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Timer : MonoBehaviour
{
    public float timeLeft = 0;
    public bool isTimeRunning = true;
    public TMP_Text timeText;

    // Start is called before the first frame update
    void Start()
    {
        isTimeRunning = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(isTimeRunning)
        {
            if(timeLeft >= 0)
            {
                timeLeft += Time.deltaTime;
                showTime(timeLeft);
            }
        }
    }

    void showTime(float time)
    {
        time += 1;
        float minutes = Mathf.FloorToInt(time / 60);
        float seconds = Mathf.FloorToInt(time % 60);
        timeText.text = string.Format("{0:00} : {1:00}", minutes, seconds);
    }
}
