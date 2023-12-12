using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowPlayerName : MonoBehaviour
{
    public TextMeshProUGUI text;
    public string message;
    public string message2;

    private void Start()
    {
        ShowName();
    }
    public void ShowName()
    {
        text.text = message + PlayerPrefs.GetString("PilotID") + message2;
    }
}
