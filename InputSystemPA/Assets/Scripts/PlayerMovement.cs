using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private PlayerInput input;
    [SerializeField] private float speed;

    private void Awake()
    {
        AwakeMetod();
    }

    private void AwakeMetod()
    {
        rb = GetComponent<Rigidbody2D>();
        input = GetComponent<PlayerInput>();
    }

    private void FixedUpdate()
    {
        rb.velocity = input.MovVector * speed;
    }
}
