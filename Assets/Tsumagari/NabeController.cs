using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NabeController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (LayerMask.LayerToName(collision.gameObject.layer) == "Vegetable")
        {
            Debug.Log("–ìØ‚ğE‚¢‚Ü‚µ‚½");
        }
    }

}
