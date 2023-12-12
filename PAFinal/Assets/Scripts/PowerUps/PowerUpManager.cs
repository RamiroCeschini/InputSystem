using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpManager : MonoBehaviour
{
    [SerializeField] private FactoryPowerUp factory;
    [SerializeField] private List<string> powerUpsList;
    [SerializeField] private float minXSpawn;
    [SerializeField] private float maxXSpawn;
    [SerializeField] private float minYSpawn;
    [SerializeField] private float maxYSpawn;


    public void CallCreatePowerUp(string powerUp)
    {
        transform.position = new Vector2(Random.Range(minXSpawn, maxXSpawn), Random.Range(minYSpawn, maxYSpawn));
        for(int i = 0; i < powerUpsList.Count; i++)
        {
            if (powerUpsList[i] == powerUp)
            {
                factory.CreatePowerUp(powerUpsList[i], transform);
            }
        }
    }
}
