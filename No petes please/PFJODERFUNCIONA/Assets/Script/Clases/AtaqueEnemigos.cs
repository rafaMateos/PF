using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtaqueEnemigos : MonoBehaviour
{
    //Varibles de script
    private bool estaEnAtaque;

    /// <summary>
    /// Funcion awake la cual se encarga de gestionar la repiticion del metodo
    /// </summary>
    private void Awake()
    {
        InvokeRepeating("esperarParaDaño", 1f, 1f);
    }

    /// <summary>
    /// Funcion start, asignacion valores variables
    /// </summary>
    private void Start()
    {
        estaEnAtaque = false;
    }

    /// <summary>
    /// Evento salida de la colision y su consiguiente cambio de estado de variable
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionExit2D(Collision2D collision)
    {
        estaEnAtaque = false;
    }

    /// <summary>
    /// Evento entrada de la colision y su consiguiente cambio de estado de variable
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionEnter2D(Collision2D collision)
    {
        estaEnAtaque = true;
        if (collision.collider.tag.Equals("Player") && AtributosJugador.vidas > 0)
        {
            ControladorSalud.DisminuirVida();
           
        }
    }

    /// <summary>
    /// Funcion la cual gestionara cuando tiene que atacar y cuando no
    /// </summary>
    void esperarParaDaño() {
        if(estaEnAtaque)
        ControladorSalud.DisminuirVida();

    }



}
