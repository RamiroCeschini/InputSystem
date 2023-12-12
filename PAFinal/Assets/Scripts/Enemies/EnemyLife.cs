using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class EnemyLife : UnitLife,ILifeSystem
{
    [SerializeField] private ScriptableEnemy enemyInfo;
    [SerializeField] private WaveManager waveInfo;
    private bool firstEnable = true;
    private EnemyLifeManager lifeUI;
    
    private void Awake()
    {
        unitType = "Enemy";
        MaxLife = enemyInfo.S_maxLife;
        lifeUI = GetComponent<EnemyLifeManager>();
        waveInfo = GameObject.FindGameObjectWithTag("Wave").GetComponent<WaveManager>();
    }

    private void OnEnable()
    {
        if (firstEnable) { firstEnable = false;  return; }
        CurrentLife = MaxLife;
        lifeUI.UpdateLife();
    }

    public override void TakeDamage(int damage)
    {
        CurrentLife -= damage;
        lifeUI.UpdateLife();
    }
    protected override void OnDeath()
    {
        gameObject.SetActive(false);
        waveInfo.EnemyDeathCount();
    }
}
