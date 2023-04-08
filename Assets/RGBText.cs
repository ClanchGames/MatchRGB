using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RGBText : MonoBehaviour {
    private TextMeshProUGUI text;

    public enum RGB {
        R,
        G,
        B
    }

    public RGB rgb;

    // Start is called before the first frame update
    private void Start () {
        text = GetComponent<TextMeshProUGUI> ();
    }

    // Update is called once per frame
    private void Update () {
        //text.text = MainManager.main.settingColor.r.ToString();
    }
}