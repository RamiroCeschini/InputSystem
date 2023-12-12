using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InputSystemPrefs : MonoBehaviour
{

    public TMP_InputField inputField;
    public GameObject pleaseText;
    public CanvasContainer canvas;
    public CanvasManager canvasManager;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            PlayerPrefs.DeleteAll();
        }
    }
    private void Awake()
    {
        if (PlayerPrefs.HasKey("PilotID"))
        {
            canvasManager.ChangeCanvas(canvas);
        }
    }
    public void SaveName()
    {
        if(inputField.text != "")
        {
            PlayerPrefs.SetString("PilotID", inputField.text);
            canvasManager.ChangeCanvas(canvas);
        }
        else
        {
            pleaseText.SetActive(true);
        }

    }




}
