using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class WinCount : MonoBehaviour
{
    private TextMeshProUGUI winCountText;

    // Start is called before the first frame update
    private void Start()
    {
        winCountText = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (MainManager.main.isGameOver)
        {
            return;
        }

        // winCountText.text = MainManager.main.WinCount.ToString() + " Win";
    }
}