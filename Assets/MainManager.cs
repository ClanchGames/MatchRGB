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

    public Color32 currentColor;
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
}