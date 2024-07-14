using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rikisi : MonoBehaviour
{
    [SerializeField] Sekiwake sekiwake;
    SpriteRenderer spriteRenderer;
    [SerializeField] Sprite sprite1;
    [SerializeField] Sprite sprite2;
    [SerializeField] Sprite sprite3;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>(); 
    }
    void Update()
    {
        if (sekiwake._class == 1)
        {
            spriteRenderer.sprite = sprite1;
        }
        else if (sekiwake._class == 2)
        {
            spriteRenderer.sprite = sprite2;
        }
        else if (sekiwake._class == 3)
        {
            spriteRenderer.sprite = sprite3;
        }
    }
}
