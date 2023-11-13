using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletInteraction : MonoBehaviour
{
    [SerializeField] private float bulletLifeTime;
    [SerializeField] private TrailRenderer trailRenderer;
    private bool FirstEnable = true;

    private void OnEnable()
    {
        if (FirstEnable) { FirstEnable = false; return; }
        Invoke("DestroyBullet", bulletLifeTime);
    }
    private void DestroyBullet()
    {
        gameObject.SetActive(false);
        trailRenderer.Clear();
    }
}
