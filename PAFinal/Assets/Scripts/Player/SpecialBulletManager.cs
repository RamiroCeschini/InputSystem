using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialBulletManager : MonoBehaviour
{
    [SerializeField] private int SBCapacity;
    [SerializeField] private List<GameObject> bulletIcons;
    private int sbLeft;
    public int SBLeft
    {
        get { return sbLeft; }
        private set
        {
            if (value > 0 && value < SBCapacity)
            {
                sbLeft = value;
            }
            else if (value >= SBCapacity)
            {
                sbLeft = SBCapacity;
            }
            else if (value <= 0)
            {
                sbLeft = 0;
            }
        }
    }

    private void Start()
    {
        sbLeft = 0;
    }

    public void ChangeSBLeft(int amount)
    {
        SBLeft = SBLeft + amount;
        for (int i = 0; i < bulletIcons.Count; i++)
        {
            for (int o = 0; o < SBLeft; o++)
            { 
                bulletIcons[o].SetActive(true);
            }
            bulletIcons[i].SetActive(false);
        }
    }

}
