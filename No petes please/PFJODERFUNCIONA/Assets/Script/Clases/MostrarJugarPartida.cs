using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MostrarJugarPartida : MonoBehaviour
{

    public Canvas canvas;
    private bool estaMostrado;

    private void Start()
    {
        estaMostrado = false;
    }
    public void mostrarCanvasNombrePartida() {

        canvas.enabled = true;
    }

    public void NOmostrarCanvasNombrePartida()
    {
        canvas.enabled = false;
    }

}
