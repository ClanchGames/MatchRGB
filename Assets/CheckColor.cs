using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckColor : MonoBehaviour
{
    //private Color32 color;
    private Image image;

    // Start is called before the first frame update
    private void Start()
    {
        image = GetComponent<Image>();
        //color = image.color;
    }

    // Update is called once per frame
    private void Update()
    {
    }
    public void ChangeColor()
    {
        MainManager.main.checkColor.a = 255;
        image.color = MainManager.main.checkColor;
        Debug.Log(image.color);
        Debug.Log((byte)image.color.r);
        Debug.Log((byte)image.color.g);
        Debug.Log((byte)image.color.b);
    }
}