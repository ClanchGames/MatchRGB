using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static MainManager;
public class RGBText : MonoBehaviour
{
    TMP_InputField input;
    // private TextMeshProUGUI text;

    public enum RGB
    {
        R,
        G,
        B
    }

    public RGB rgb;

    // Start is called before the first frame update
    private void Start()
    {
        //text = GetComponent<TextMeshProUGUI>();
        input = GetComponent<TMP_InputField>();
        input.onEndEdit.AddListener(OnEndEdit);
    }

    // Update is called once per frame
    private void Update()
    {
        //text.text = MainManager.main.settingColor.r.ToString();
    }

    void OnEndEdit(string text)
    {
        int rgbint = int.Parse(text);
        byte rgbbyte = (byte)rgbint;
        if (rgbint > 255)
        {
            Debug.Log(rgbint);
            main.RGBErrorMessage();
            return;
        }
        if (rgb == RGB.R)
        {
            main.checkColor.r = rgbbyte;
        }
        if (rgb == RGB.G)
        {
            main.checkColor.g = rgbbyte;
        }
        if (rgb == RGB.B)
        {
            main.checkColor.b = rgbbyte;
        }
    }
}