using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarAnimaciones : MonoBehaviour
{
    Animator animacion;
    public string Nombreanimacion;
    BoxCollider2D collider;
    private bool esColision;
    public GameObject item;
    private Transform posJug;
    private bool estaAbierto;
    public bool estaAbiertoCarga = false;

    
    void Start()
    {
        animacion = GetComponent<Animator>();
        collider = GetComponent<BoxCollider2D>();
        posJug = GameObject.FindGameObjectWithTag("Player").transform;
        estaAbierto = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        esColision = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        esColision = false;

    }

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
        }
    }



}
