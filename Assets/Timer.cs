using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private float hour;
    private float minute;
    private float seconds;
    private TextMeshProUGUI timerText;

    // Start is called before the first frame update
    private void Start()
    {
        timerText = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (!MainManager.main.isGameStart || MainManager.main.isGameOver)
        {
            return;
        }
        seconds += Time.deltaTime;
        if (seconds >= 60f)
        {
            minute++;
            seconds -= 60;
        }
        if (minute >= 60f)
        {
            hour++;
            minute -= 60;
        }
        timerText.text = hour.ToString("00") + ":" + minute.ToString("00") + ":" + ((int)seconds).ToString("00");
    }
}