using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharactorController : MonoBehaviour
{
    [SerializeField] float speed = 0f;

    void Start()
    {
    }

    void Update()
    {

        Vector2 position = transform.position;

        if (Input.GetKey(KeyCode.A))
        {
            position.x -= speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            position.x += speed * Time.deltaTime;
        }
        transform.position = position;

    }
}