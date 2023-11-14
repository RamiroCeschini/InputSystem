using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveManager : MonoBehaviour
{
    [SerializeField] private List<string> enemyTypes;
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private int totalEnemiesInWave;
    [SerializeField] private int enemiesKilled;
    private int timeBeetween;
    private void OnEnable()
    {
        for (int i = 0; i < totalEnemiesInWave; i++)
        {
            Invoke("CreateEnemy",timeBeetween);
            timeBeetween += 3;
        }
    }
    private void CreateEnemy()
    {
        GameObject enemy = ObjectPool.SharedInstance.GetPooledObject(enemyTypes[0]);
        enemy.transform.position = spawnPoint.transform.position;
        enemy.transform.rotation = spawnPoint.transform.rotation;
        enemy.SetActive(true);
    }

    public void EnemyDeathCount()
    {
        enemiesKilled++;
        if(enemiesKilled == totalEnemiesInWave)
        {
            GameManager.SharedInstance.WaveClear();
        }
    }
}
