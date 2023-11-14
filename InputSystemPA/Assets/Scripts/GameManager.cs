using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [HideInInspector]
    public static GameManager SharedInstance;
    private void Awake()
    {
        SingletonSet();
    }
    private void SingletonSet()
    {
        if (SharedInstance != null && SharedInstance != this)
        {
            Destroy(this);
        }
        else
        {
            SharedInstance = this;
        }
    }

    public void WaveClear()
    {
        SceneManager.LoadScene(1);
    }

    public void PlayerDeath()
    {
        SceneManager.LoadScene(2);
    }

}
