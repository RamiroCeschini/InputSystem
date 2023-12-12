using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;

public class WaveManager : MonoBehaviour
{ 
    [SerializeField] private List<string> enemyTypes;
    [SerializeField] private List<Transform> spawnPoints;
    private int totalEnemiesInWave;
    [SerializeField] private WaveTLManager waveTLManager;
    [SerializeField] private List<int> enemiesPerLevel;

    private int enemiesCreated;
    private int enemiesKilled;

    private int enemiesInWave;
    private bool hasCounted = false;

    private void Start()
    {
        totalEnemiesInWave = enemiesPerLevel[GameManager.SharedInstance.levelToCharge - 1];
    }
    public void CreateEnemy(string enemyType)
    {
        for (int i = 0; i < enemyTypes.Count; i++ )
        {
            if (enemyTypes[i] == enemyType)
            {
                GameObject enemy = ObjectPool.SharedInstance.GetPooledObject(enemyType);
                enemy.transform.position = spawnPoints[i].transform.position;
                enemy.transform.rotation = spawnPoints[i].transform.rotation;
                enemy.SetActive(true);
                enemiesCreated++;
            }
        }

    }

    public void CountEnemiesInWave()
    {
        enemiesInWave = enemiesCreated;
        hasCounted = true;
    }

    public void EnemyDeathCount()
    {
        enemiesKilled++;
        if (NextWave())
        {
            waveTLManager.PlayTimeLine();
        }
        if(enemiesKilled == totalEnemiesInWave)
        {
            GameManager.SharedInstance.WaveClear();
        }
    }

    private bool NextWave()
    {
        return hasCounted && enemiesKilled == enemiesInWave;
    }
}
