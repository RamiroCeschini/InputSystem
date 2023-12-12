using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasManager : MonoBehaviour
{
    private bool currentCanvas = false;
    public void ChangeCanvas(CanvasContainer conteiner)
    {
        if (!currentCanvas)
        {
            conteiner.canvas1.SetActive(false);
            conteiner.canvas2.SetActive(true);
            currentCanvas = true;
        }
        else
        {
            conteiner.canvas2.SetActive(false);
            conteiner.canvas1.SetActive(true);
            currentCanvas = false;
        }
    }
}
