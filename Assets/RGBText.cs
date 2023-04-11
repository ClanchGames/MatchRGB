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
        if (input.text == "")
        {
            main.isEditColor = false;
        }
    }

    void OnEndEdit(string text)
    {
        int rgbint;
        if (!int.TryParse(text, out rgbint) || rgbint > 255)
        {
            if (text == "")
            {
                return;
            }
            main.RGBErrorMessage();
            return;
        }
        byte rgbbyte = (byte)rgbint;
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
        main.isEditColor = true;
    }
}