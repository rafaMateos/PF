using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mensaje : MonoBehaviour
{
    //Variables de clase
    public static bool mensaje = false;
    BoxCollider2D collider;

    private void Start()
    {
        collider = GetComponent<BoxCollider2D>();   
    }

    /// <summary>
    /// Funcion la cual nos mostrara el mensaje tras perder si estamos en alguna puerta sin llaves
    /// </summary>
    private void OnGUI()
    {
        Rect rect = new Rect(Screen.width / 2 - 10, 125, 300, 50);
        if (llave.tieneLaLlave)
        {
            if (mensaje)
            {
                collider.isTrigger = true;
                GUI.Label(rect, "Si puedes pasar");
            }
        }
        else
        {
            if (mensaje)
            {
                GUI.Label(rect, "No tienes la llave aun.. se parece a un libro");
            }
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        mensaje = true;
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
         mensaje = false;
    }

}
