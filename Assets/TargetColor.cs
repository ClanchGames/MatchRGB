using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TargetColor : MonoBehaviour
{
    private Image image;

    // Start is called before the first frame update
    private void Start()
    {
        image = GetComponent<Image>();
        SetColor();
    }

    // Update is called once per frame
    private void Update()
    {
    }

    private void SetColor()
    {
        int r = Random.Range(0, 256);
        // Debug.Log(r);
        // Debug.Log((byte)r);
        int g = Random.Range(0, 256);
        int b = Random.Range(0, 256);
        image.color = new Color32((byte)r, (byte)g, (byte)b, 255);
    }
}