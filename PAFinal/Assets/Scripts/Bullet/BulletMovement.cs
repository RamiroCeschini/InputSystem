using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    private Rigidbody2D bulletRb;
    [SerializeField] ScriptableBullet bulletInfo;

    private void Awake()
    {
        bulletRb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        Vector2 bulletDirection = new Vector2(-Mathf.Sin(bulletRb.rotation * Mathf.Deg2Rad), Mathf.Cos(bulletRb.rotation * Mathf.Deg2Rad));
        bulletRb.velocity = bulletDirection * bulletInfo.S_speed;
    }
}
