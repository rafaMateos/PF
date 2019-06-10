using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtaqueEnemigos : MonoBehaviour
{
    private bool estaEnAtaque;

    private void Awake()
    {
        InvokeRepeating("esperarParaDaño", 1f, 1f);
    }
    private void Start()
    {
        estaEnAtaque = false;
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        estaEnAtaque = false;
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        estaEnAtaque = true;
        if (collision.collider.tag.Equals("Player") && AtributosJugador.vidas > 0)
        {
            ControladorSalud.DisminuirVida();
           
        }
    }

    void esperarParaDaño() {
        if(estaEnAtaque)
        ControladorSalud.DisminuirVida();

    }



}
