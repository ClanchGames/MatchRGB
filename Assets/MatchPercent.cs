using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using static MainManager;

public class MatchPercent : MonoBehaviour
{
    TextMeshProUGUI text;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        int correctR = (int)main.targetColor.r;
        int correctG = (int)main.targetColor.g;
        int correctB = (int)main.targetColor.b;

        int checkR = (int)main.checkColor.r;
        int checkG = (int)main.checkColor.g;
        int checkB = (int)main.checkColor.b;

        int diffR = Mathf.Abs(correctR - checkR);
        int diffG = Mathf.Abs(correctG - checkG);
        int diffB = Mathf.Abs(correctB - checkB);
        float ave = (diffR + diffG + diffB) / 3.0f;
        //float ave=
        Debug.Log(ave);
        float percent = 100 * (1 - (ave / 255));
        percent = Mathf.Floor(percent);
        text.text = $"({percent}%)";


    }
}
