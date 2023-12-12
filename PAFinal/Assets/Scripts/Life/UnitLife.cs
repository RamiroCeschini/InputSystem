using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitLife : MonoBehaviour
{
    [SerializeField] protected int maxLife;
    protected int currentLife;
    public string unitType;

    public int MaxLife
    {
        get { return maxLife; }
        protected set { maxLife = value; }
    }
    public int CurrentLife
    {
        get { return currentLife; }
        protected set
        {
            if (value > 0 && value < maxLife)
            {
                currentLife = value;
            }
            else if (value >= maxLife)
            {
                currentLife = maxLife;
            }
            else if (value <= 0)
            {
                currentLife = 0;
                OnDeath();
            }

        }
    }

    public virtual void TakeDamage(int damage) { }
    protected virtual void OnDeath() { }
}
