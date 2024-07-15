using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTestMove : MonoBehaviour
{
    [Header("ˆÚ“®‘¬“x")]
    [SerializeField]
    private float _speed;
    private float _h;
    private Rigidbody2D _rb;
    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        _h = Input.GetAxisRaw("Horizontal");
        _rb.velocity = Vector2.right * _h * _speed;
    }
}
