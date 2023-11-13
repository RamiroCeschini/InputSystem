using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoolDownPowerUp : PowerUp,Iinteractive
{
    [SerializeField] private float coolDownReduction;
    public override string powerUpName => "CoolDownPowerUp";
    public void Action(GameObject callOrigin)
    {
        PlayerShoot player = callOrigin.GetComponent<PlayerShoot>();
        player.BulletChange(player.CoolDown * coolDownReduction,player.CurrentBullet);
        Destroy(gameObject);
    }
}
