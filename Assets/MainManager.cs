using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainManager : MonoBehaviour
{
    public static MainManager main;

    public bool isGameOver { get; set; } = false;
    public bool isGameStart { get; set; } = false;

    [SerializeField]
    private GameObject GameOverWindow;

    [SerializeField]
    private GameObject GameStartText;

    public Color32 checkColor;
    public Color32 targetColor;


    // Start is called before the first frame update
    private void Start()
    {
        main = this;
    }

    // Update is called once per frame
    private void Update()
    {
    }

    public void CheckColor()
    {
        int Rdif = targetColor.r - checkColor.r;
        int Gdif = targetColor.g - checkColor.g;
        int Bdif = targetColor.b - checkColor.b;
        // Debug.Log("rdif" + Rdif);
        //  Debug.Log("gdif" + Gdif);
        //  Debug.Log("bdif" + Bdif);
    }

    public void GameStart()
    {
        isGameOver = false;
        isGameStart = true;
        GameStartText.SetActive(false);
    }

    public void GameOver()
    {
        GameOverWindow.SetActive(true);
        isGameOver = true;
        //isGameStart = false;
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    [SerializeField] GameObject MessageWindow;
    public string messageText { get; set; }

    public void RGBErrorMessage()
    {
        messageText = "Check if RGB number is correct.";
        ShowMessage();
        Invoke("HideMessage", 2f);
    }
    public void ShowMessage()
    {
        MessageWindow.SetActive(true);
    }
    public void HideMessage()
    {
        MessageWindow.SetActive(false);
    }
}