using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementBase : MonoBehaviour
{
    [SerializeField] ScriptableEnemy enemyInfo;
    private Rigidbody2D rb;
    private float speed;
    private void Start()
    {
        speed = enemyInfo.S_speed;
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnEnable()
    {
        InvokeRepeating("ChangeDirection", 0f, 2f);
    }
    private void Update()
    {
        if (gameObject.activeInHierarchy)
        {
            rb.velocity = new Vector2(speed, 0);
            return;
        }
        CancelInvoke("ChangeDirection");
    }

    private void ChangeDirection()
    {
        speed = -speed;
    }
}
