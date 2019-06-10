using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventarioActivacion : MonoBehaviour
{

    private Canvas inventarioJugador;
    private bool esMostrado;

    private void Start()
    {
        inventarioJugador = GetComponent<Canvas>();
        esMostrado = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.I) && !esMostrado)
        {

            inventarioJugador.enabled = true;
            esMostrado = true;
        }
        else if (Input.GetKeyDown(KeyCode.I) && esMostrado) {

            inventarioJugador.enabled = false;
            esMostrado = false;
        }
    }
}
