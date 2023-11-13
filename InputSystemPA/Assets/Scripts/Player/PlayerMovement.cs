using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private PlayerInput input;
    [SerializeField] private float speed;
    [SerializeField] private float rotationLimit;

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
        rb.MoveRotation(- input.MovVector.x * rotationLimit);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Iinteractive interactiveObject))
        {
            interactiveObject.Action(gameObject);
        }

        return;
    }
}
