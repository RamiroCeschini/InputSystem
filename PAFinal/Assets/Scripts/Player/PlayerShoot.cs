using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private float coolDown;
    [SerializeField] private SpecialBulletManager sbManager;
    private float normalCoolDown;
    private float lastShotTime;
    private string normalBullet = "NormalBullet";

    private void Start()
    {
        normalCoolDown = coolDown;
    }

    public float CoolDown 
    {
        get { return coolDown; }

        set 
        { 
            coolDown = value;
            Invoke("RestartCD", 5f);
        }
    }

    public void Shoot()
    {
        if (Time.time - lastShotTime < coolDown) { return; }
        lastShotTime = Time.time;
        GetBulletFromPool(normalBullet);
    }

    public void SpecialShoot()
    {
        if (Time.time - lastShotTime < coolDown) { return; }
        lastShotTime = Time.time;
        if (sbManager.SBLeft > 0)
        {
            GetBulletFromPool("CannonBullet");
            sbManager.ChangeSBLeft(-1);
        }
    }

    private void GetBulletFromPool(string bulletName)
    {
        GameObject bullet = ObjectPool.SharedInstance.GetPooledObject(bulletName);
        bullet.transform.position = spawnPoint.transform.position;
        bullet.transform.rotation = spawnPoint.transform.rotation;
        bullet.GetComponent<BulletInteraction>().bulletEmisor = "Player";
        bullet.SetActive(true);
    }

    private void RestartCD()
    {
        coolDown = normalCoolDown;
    }

}
