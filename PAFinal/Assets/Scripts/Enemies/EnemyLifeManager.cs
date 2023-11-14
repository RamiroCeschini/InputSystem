using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyLifeManager : MonoBehaviour
{
    private EnemyLife lifeReference;
    [SerializeField] private Image lifeBar;

    private void Awake()
    {
        lifeReference = GetComponent<EnemyLife>();
    }

    public void UpdateLife()
    {
        float currentLife = lifeReference.CurrentLife;
        float maxLife = lifeReference.MaxLife;
        lifeBar.fillAmount = currentLife / maxLife;
    }
}
