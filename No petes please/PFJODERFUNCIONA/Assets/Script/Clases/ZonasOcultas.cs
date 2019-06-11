using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZonasOcultas : MonoBehaviour
{

    public GameObject llaveAbierta;
    private bool estaEnPuerta;
    public GameObject puertaAbrir;
    private bool yaAbierta;
    public Canvas msg;

    private void Start()
    {
        puertaAbrir.GetComponent<Animator>().Play("iddle");
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player")) {
            switch (tag)
            {
                case "llave1":
                    if (AtributosLlaves.llave1)
                    {
                        estaEnPuerta = true;
                    }
                    else {
                        msg.enabled = true;
                    }
                    break;

                case "llave2":
                    if (AtributosLlaves.llave2)
                    {
                        estaEnPuerta = true;
                    }
                    else
                    {
                        msg.enabled = true;
                    }
                    break;

                case "llave3":
                    if (AtributosLlaves.llave3)
                    {
                        estaEnPuerta = true;
                    }
                    else
                    {
                        msg.enabled = true;
                    }
                    break;


                case "llave4":
                    if (AtributosLlaves.llave4)
                    {
                        estaEnPuerta = true;
                    }
                    else
                    {
                        msg.enabled = true;
                    }
                    break;

                case "llave6":
                    if (AtributosLlaves.llave6)
                    {
                        estaEnPuerta = true;
                    }
                    else
                    {
                        msg.enabled = true;
                    }
                    break;
            }
        }
      
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            estaEnPuerta = false;
            if (msg.isActiveAndEnabled) {

                msg.enabled = false;
            }
        }
    }

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.E) && estaEnPuerta)
        {
            cambiarEstadoPuertas();
            GetComponent<AudioSource>().Play();
            GetComponent<SpriteRenderer>().sprite = llaveAbierta.GetComponent<SpriteRenderer>().sprite;
            puertaAbrir.GetComponent<BoxCollider2D>().enabled = false;
            puertaAbrir.GetComponent<Animator>().Play("parar");
            yaAbierta = true;
            StartCoroutine(acabarConObjeto());
        }
        else {

          
        }

        
      
    }

    private void cambiarEstadoPuertas() {

        switch (puertaAbrir.tag) {

            case "puerta1":
                DatosPartida.puerta1 = true;
                break;

            case "puerta2":
                DatosPartida.puerta2 = true;
                break;

            case "puerta3":
                DatosPartida.puerta3 = true;
                break;
            case "puerta4":
                DatosPartida.puerta4 = true;
                break;
            case "puerta5":
                DatosPartida.puerta5 = true;
                break;
            case "puerta6":
                DatosPartida.puerta6 = true;
                break;
            case "puerta7":
                DatosPartida.puerta7 = true;
                break;
        }
    }

    IEnumerator acabarConObjeto() {

        yield return new WaitForSeconds(1f);
        Destroy(puertaAbrir);
    }
}
