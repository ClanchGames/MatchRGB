using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrentColor : MonoBehaviour
{
    private Color color;
    private Image image;

    // Start is called before the first frame update
    private void Start()
    {
        image = GetComponent<Image>();
        color = image.color;
    }

    // Update is called once per frame
    private void Update()
    {
    }
}