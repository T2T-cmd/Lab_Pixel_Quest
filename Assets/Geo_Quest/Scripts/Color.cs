using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorSwitcher : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    private Color color1 = new Color(1f, 0f, 0f); // Red
    private Color color2 = new Color(0f, 1f, 0f); // Green
    private Color color3 = new Color(0f, 0f, 1f); // Blue

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        if (spriteRenderer == null)
        {
            Debug.LogError("SpriteRenderer not found on this object.");
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SetColor(color1);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SetColor(color2);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            SetColor(color3);
        }
    }

    void SetColor(Color color)
    {
        if (spriteRenderer != null)
        {
            spriteRenderer.color = color;
        }
    }
}

