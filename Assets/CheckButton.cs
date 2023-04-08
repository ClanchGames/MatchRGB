using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static MainManager;
public class CheckButton : MonoBehaviour
{
    string checkColorObjectName = "CheckColor";
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(OnClick);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnClick()
    {
        GameObject.Find(checkColorObjectName).GetComponent<CheckColor>().ChangeColor();
        main.CheckColor();
    }
}