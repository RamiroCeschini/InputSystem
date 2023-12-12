using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public void ChargeLevel(int level)
    {
        GameManager.SharedInstance.levelToCharge = level;
        SceneManager.LoadScene(1);
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void Next()
    {
        SceneManager.LoadScene(1);
        Cursor.lockState = CursorLockMode.Locked;

        if (GameManager.SharedInstance.levelToCharge == GameManager.SharedInstance.totalLevels + 1)
        {
            GoToMenu();
        }
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene(0);
        Cursor.lockState = CursorLockMode.None;
    }
    public void Exit()
    {
        Application.Quit();
    }

}
