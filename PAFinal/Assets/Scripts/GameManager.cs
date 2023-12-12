using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [HideInInspector]
    public static GameManager SharedInstance;
    public int levelToCharge = 1;
    public int totalLevels;
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
            DontDestroyOnLoad(gameObject);
        }
    }


    public void WaveClear()
    {
        levelToCharge++;
        SceneManager.LoadScene(2);
        Cursor.lockState = CursorLockMode.None;
    }

    public void PlayerDeath()
    {
        SceneManager.LoadScene(3);
        Cursor.lockState = CursorLockMode.None;
    }


}


