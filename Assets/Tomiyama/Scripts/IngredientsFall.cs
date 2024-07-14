using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngredientsFall : MonoBehaviour
{
    private float _speed;
    public float Speed { set => _speed = value; }

    private void FixedUpdate()
    {
        transform.Translate(Vector2.down * Time.deltaTime * _speed);
    }
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
