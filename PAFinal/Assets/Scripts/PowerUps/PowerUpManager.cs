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

    private void Start()
    {
        InvokeRepeating("CallCreatePowerUp", 2f, Random.Range(8f, 10f));
    }

    private void CallCreatePowerUp()
    {
        transform.position = new Vector2(Random.Range(minXSpawn, maxXSpawn), Random.Range(minYSpawn, maxYSpawn));
        factory.CreatePowerUp(powerUpsList[Random.Range(0, powerUpsList.Count)], transform);
    }
}
