using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoolDownPowerUp : PowerUp,Iinteractive
{
    [SerializeField] private float coolDownReduction;
    public override string powerUpName => "CoolDownPowerUp";
    public void Action(GameObject callOrigin)
    {
        callOrigin.GetComponent<PlayerShoot>().CoolDown *= coolDownReduction;
        Destroy(gameObject);
    }
}
