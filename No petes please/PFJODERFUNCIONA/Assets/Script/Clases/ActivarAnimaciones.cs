using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarAnimaciones : MonoBehaviour
{
    //Atributos script
    Animator animacion;
    public string Nombreanimacion;
    BoxCollider2D collider;
    private bool esColision;
    public GameObject item;
    private Transform posJug;
    private bool estaAbierto;
    public bool estaAbiertoCarga = false;

    /// <summary>
    /// Metodo start en el cual se le dan valores a los atributos
    /// </summary>
    void Start()
    {
        animacion = GetComponent<Animator>();
        collider = GetComponent<BoxCollider2D>();
        posJug = GameObject.FindGameObjectWithTag("Player").transform;
        estaAbierto = false;
    }

    /// <summary>
    /// Evento colision 
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionEnter2D(Collision2D collision)
    {
        esColision = true;
    }

    /// <summary>
    /// Evento salida colision
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionExit2D(Collision2D collision)
    {
        esColision = false;

    }

    /// <summary>
    /// Funcion update la cual se encargara de las animaciones de los cofres , y todo lo que ello con lleva(Drop de objetos , instanciacion cerca jugador..)
    /// </summary>
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && esColision && !estaAbierto && !estaAbiertoCarga)
        {
            estadoPartidaCofres();
            animacion.Play(Nombreanimacion);
            GetComponent<AudioSource>().Play();
            Vector2 pos = new Vector2(posJug.position.x, posJug.position.y - 2);
            Instantiate(item, pos, Quaternion.identity);
            esColision = false;
            estaAbierto = true;

        }
       
        
    }

    /// <summary>
    /// Funcion la cual obtiene segun tag el estado del cofre abierto
    /// </summary>
    private void estadoPartidaCofres() {

        switch (tag)
        {
            case "cofre1":
                DatosPartida.cofre1 = true;
                break;

            case "cofre2":
                DatosPartida.cofre2 = true;
                break;

            case "cofre3":
                DatosPartida.cofre3 = true;
                break;

            case "cofre4":
                DatosPartida.cofre4 = true;
                break;

            case "cofre5":
                DatosPartida.cofre5 = true;
                break;

            case "cofre6":
                DatosPartida.cofre6 = true;
                break;

            case "cofre7":
                DatosPartida.cofre7 = true;
                break;

            case "cofre8":
                DatosPartida.cofre8 = true;
                break;

            case "cofre9":
                DatosPartida.cofre9 = true;
                break;

            case "cofre10":
                DatosPartida.cofre10 = true;
                break;

            case "cofre11":
                DatosPartida.cofre11 = true;
                break;

            case "cofre12":
                DatosPartida.cofre12 = true;
                break;

            case "cofre13":
                DatosPartida.cofre13 = true;
                break;

            case "cofre14":
                DatosPartida.cofre14 = true;
                break;

            case "cofre15":
                DatosPartida.cofre8 = true;
                break;

            case "cofre16":
                DatosPartida.cofre16 = true;
                break;

            case "cofre17":
                DatosPartida.cofre17 = true;
                break;
        }
    }



}
