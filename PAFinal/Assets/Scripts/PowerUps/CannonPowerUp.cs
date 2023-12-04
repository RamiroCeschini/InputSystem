using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonPowerUp : PowerUp, Iinteractive
{
    [SerializeField] private ScriptableBullet bulletInfo;
    public override string powerUpName => "CannonPowerUp";
    public void Action(GameObject callOrigin)
    {
       callOrigin.GetComponent<SpecialBulletManager>().ChangeSBLeft(1);
        Destroy(gameObject);
    }

}
