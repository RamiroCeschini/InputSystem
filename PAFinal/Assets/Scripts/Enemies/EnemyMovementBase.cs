using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementBase : MonoBehaviour
{
    [SerializeField] ScriptableEnemy enemyInfo;
    [SerializeField] private Rigidbody2D rb;
    private float speed;
    private bool firstEnable = true;
    private void Start()
    {
        speed = enemyInfo.S_speed;
    }

    private void OnEnable()
    {
        if (firstEnable) { firstEnable = false; return; }
        SetVelocity(speed, 0f);
        InvokeRepeating("ChangeDirection", 2f, 2f);
    }

    private void OnDisable()
    {
        SetVelocity(0f, 0f);
        CancelInvoke("ChangeDirection");
        speed = enemyInfo.S_speed;
    }

    private void SetVelocity(float velocityX, float velocityY)
    {
        rb.velocity = new Vector2(velocityX, velocityY);
    }

    private void ChangeDirection()
    {
        speed = -speed;
        SetVelocity(speed, 0);
    }
}
