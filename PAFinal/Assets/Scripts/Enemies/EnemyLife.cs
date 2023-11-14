using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class EnemyLife : MonoBehaviour,ILifeSystem
{
    [SerializeField] private ScriptableEnemy enemyInfo;
    [SerializeField] private WaveManager waveInfo;
    private bool firstEnable = true;
    private EnemyLifeManager lifeUI;
    private int currentLife;
    public int MaxLife
    {
        get { return enemyInfo.S_maxLife; }
    }
    public int CurrentLife
    {
        get { return currentLife; }
        private set
        {
            if (value > 0 && value < MaxLife)
            {
                currentLife = value;
            }
            else if (value >= MaxLife)
            {
                currentLife = MaxLife;
            }
            else if (value <= 0)
            {
                currentLife = 0;
                EnemyDeath();
            }

        }
    }

    private void Awake()
    {
        lifeUI = GetComponent<EnemyLifeManager>();
        waveInfo = GameObject.FindGameObjectWithTag("Wave").GetComponent<WaveManager>();
    }

    private void OnEnable()
    {
        if (firstEnable) { firstEnable = false;  return; }
        CurrentLife = MaxLife;
        lifeUI.UpdateLife();
    }

    public void TakeDamage(int damage)
    {
        CurrentLife -= damage;
        lifeUI.UpdateLife();
    }
    private void EnemyDeath()
    {
        gameObject.SetActive(false);
        waveInfo.EnemyDeathCount();
    }
}
