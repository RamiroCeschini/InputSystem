using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletInteraction : MonoBehaviour
{
    [SerializeField] private TrailRenderer trailRenderer;
    [SerializeField] ScriptableBullet bulletInfo;
    private void DestroyBullet()
    {
        if (gameObject.activeInHierarchy)
        { 
            gameObject.SetActive(false);
            trailRenderer.Clear(); 
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        CollisionWith(collision);
        return;
    }

    private void CollisionWith(Collider2D collisionWith)
    {
        if (collisionWith.TryGetComponent(out ILifeSystem liveObject))
        {
            liveObject.TakeDamage(bulletInfo.S_damage);
            DestroyBullet();
        }

        else if (collisionWith.CompareTag("Limit"))
        {
            DestroyBullet();
        }
    }
}
