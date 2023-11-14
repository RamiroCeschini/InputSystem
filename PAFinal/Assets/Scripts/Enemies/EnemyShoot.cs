using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    [SerializeField] private ScriptableEnemy enemyInfo;
    [SerializeField] private Transform spawnPoint;

    private void OnEnable()
    {
        InvokeRepeating("ShootLogic", 2f, enemyInfo.S_shootTime);
    }
    private void ShootLogic() 
    {
        if (gameObject.activeInHierarchy)
        {
            GameObject bullet = ObjectPool.SharedInstance.GetPooledObject(enemyInfo.S_bulletType);
            bullet.transform.position = spawnPoint.transform.position;
            bullet.transform.rotation = spawnPoint.transform.rotation;
            bullet.SetActive(true);
            return;
        }

        CancelInvoke("ShootLogic");
    }


}
