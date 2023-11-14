using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private float coolDown;
    private float lastShotTime;
    private string currentBullet = "NormalBullet";

    public string CurrentBullet { get { return currentBullet; } }
    public float CoolDown { get { return coolDown; } }


    public void Shoot()
    {
        if (Time.time - lastShotTime < coolDown) { return; }
        
        lastShotTime = Time.time;
        GetBulletFromPool(currentBullet);
    }

    private void GetBulletFromPool(string bulletName)
    {
        GameObject bullet = ObjectPool.SharedInstance.GetPooledObject(bulletName);
        bullet.transform.position = spawnPoint.transform.position;
        bullet.transform.rotation = spawnPoint.transform.rotation;
        bullet.SetActive(true);
    }

    public void BulletChange(float newCoolDown, string bulletType)
    {
        coolDown = newCoolDown;
        currentBullet = bulletType;
    }
}
