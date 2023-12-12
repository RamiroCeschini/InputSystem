using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLife : UnitLife, ILifeSystem
{
    public static event Action lifeEvent;
    private void Start()
    {
        unitType = "Player";
        currentLife = maxLife;
        lifeEvent?.Invoke();
    }
    public override void TakeDamage(int damage)
    {
        CurrentLife -= damage;
        lifeEvent?.Invoke();
    }

    protected override void OnDeath()
    {
        GameManager.SharedInstance.PlayerDeath();
    }

}
