using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactoryPowerUp : MonoBehaviour
{
    [SerializeField] private PowerUp[] powerUps;
    private Dictionary<string, PowerUp> powerUpsbyName;

    private void Awake()
    {
        powerUpsbyName = new Dictionary<string, PowerUp>();

        foreach (var power in powerUps)
        {
            powerUpsbyName.Add(power.powerUpName, power);
        }
    }

    public PowerUp CreatePowerUp(string powerName, Transform factoryTransform)
    {
        if (powerUpsbyName.TryGetValue(powerName, out PowerUp powerPrefab))
        {
            PowerUp powerInstance = Instantiate(powerPrefab, factoryTransform.position, Quaternion.identity);
            return powerInstance;
        }
        else
        {
            Debug.LogWarning($"The Power Up'{powerName}' doesn't exist in the data base PowerUps.");
            return null;
        }
    }
}