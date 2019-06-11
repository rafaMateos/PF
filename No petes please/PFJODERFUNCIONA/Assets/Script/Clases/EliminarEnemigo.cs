using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EliminarEnemigo : MonoBehaviour
{

    private Animator animator;
    private BoxCollider2D zonaAtaque;
    private AudioSource audio;

    private void Start()
    {
        animator = GetComponent<Animator>();
        zonaAtaque = GetComponent<BoxCollider2D>();
        audio = GetComponent<AudioSource>();
    }


   

  IEnumerator OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag.Equals("Ataque")) {
            if (SaludEnemigos.saludActual <= 1)
            {
                ObtenerEstadoEnemigos();
                Enemigo.speed = 0;
                GetComponent<Enemy2>().speed = 0;
                GameObject.FindGameObjectWithTag("hitEnemigo").GetComponent<AudioSource>().Play();
                gameObject.GetComponent<SpriteRenderer>().color = new Color(255, 0, 0);
                StartCoroutine(esperarParaCambioDeColorDaño());
                zonaAtaque.enabled = false;
                animator.Play("muerte");
                audio.Play();
                yield return new WaitForSeconds(2f);
                Destroy(gameObject);
                

                SaludEnemigos.saludActual = 10;
                Enemigo.speed = 2;

            }
            else {

                switch (AtributosJugador.espadaEquipada) {

                    case "espadaBasica":
                        SaludEnemigos.saludActual--;
                        Debug.Log(SaludEnemigos.saludActual);
                        GameObject.FindGameObjectWithTag("hitEnemigo").GetComponent<AudioSource>().Play();
                        gameObject.GetComponent<SpriteRenderer>().color = new Color(255, 0, 0);
                        StartCoroutine(esperarParaCambioDeColorDaño());
                        break;

                    case "espadaMedia":
                        SaludEnemigos.saludActual -= ConstantesEspadas.DANIOESPADAMEDIA;
                        Debug.Log(SaludEnemigos.saludActual);
                        GameObject.FindGameObjectWithTag("hitEnemigo").GetComponent<AudioSource>().Play();
                        gameObject.GetComponent<SpriteRenderer>().color = new Color(255, 0, 0);
                        StartCoroutine(esperarParaCambioDeColorDaño());
                        break;

                    case "espadaLegendaria":
                        SaludEnemigos.saludActual -= ConstantesEspadas.DANIOESPADALEGENDARIA;
                        Debug.Log(SaludEnemigos.saludActual);
                        GameObject.FindGameObjectWithTag("hitEnemigo").GetComponent<AudioSource>().Play();
                        gameObject.GetComponent<SpriteRenderer>().color = new Color(255, 0, 0);
                        StartCoroutine(esperarParaCambioDeColorDaño());
                        break;
                }
               
                
            }

        }
    }

    IEnumerator esperarParaCambioDeColorDaño() {

        yield return new WaitForSeconds(0.5f);
        gameObject.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255);
    }

    private IEnumerator OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Ataque"))
        {
            if (SaludEnemigos.saludActual <= 1)
            {
                ObtenerEstadoEnemigos();
                GetComponent<Enemy2>().speed = 0;
                Enemigo.speed = 0;
                zonaAtaque.enabled = false;
                animator.Play("muerte");
                audio.Play();
                yield return new WaitForSeconds(2f);
                Destroy(gameObject);

             
                SaludEnemigos.saludActual = 10;
                Enemigo.speed = 2;

            }
            else
            {

                switch (AtributosJugador.espadaEquipada)
                {

                    case "espadaBasica":
                        SaludEnemigos.saludActual--;
                        Debug.Log(SaludEnemigos.saludActual);
                        break;

                    case "espadaMedia":
                        SaludEnemigos.saludActual -= ConstantesEspadas.DANIOESPADAMEDIA;
                        Debug.Log(SaludEnemigos.saludActual);
                        break;

                    case "espadaLegendaria":
                        SaludEnemigos.saludActual -= ConstantesEspadas.DANIOESPADALEGENDARIA;
                        Debug.Log(SaludEnemigos.saludActual);
                        break;
                }


            }

        }
    }

    private void ObtenerEstadoEnemigos() {

        switch (tag) {

            case "Enemigo1":
                DatosPartida.Enemigo1 = true;
                break;

            case "Enemigo2":
                DatosPartida.Enemigo2 = true;
                break;

            case "Enemigo3":
                DatosPartida.Enemigo3 = true;
                break;

            case "Enemigo4":
                DatosPartida.Enemigo4 = true;
                break;

            case "Enemigo5":
                DatosPartida.Enemigo5 = true;
                break;
            case "Enemigo6":
                DatosPartida.Enemigo6 = true;
                break;
            case "Enemigo7":
                DatosPartida.Enemigo7 = true;
                break;
            case "Enemigo8":
                DatosPartida.Enemigo8 = true;
                break;
            case "Enemigo9":
                DatosPartida.Enemigo9 = true;
                break;
            case "Enemigo10":
                DatosPartida.Enemigo10 = true;
                break;
            case "Enemigo11":
                DatosPartida.Enemigo11 = true;
                break;
            case "Enemigo12":
                DatosPartida.Enemigo12 = true;
                break;
            case "Enemigo13":
                DatosPartida.Enemigo13= true;
                break;
            case "Enemigo14":
                DatosPartida.Enemigo14 = true;
                break;
            case "Enemigo15":
                DatosPartida.Enemigo15 = true;
                break;
            case "Enemigo16":
                DatosPartida.Enemigo16 = true;
                break;
            case "Enemigo17":
                DatosPartida.Enemigo17 = true;
                break;
            case "Enemigo18":
                DatosPartida.Enemigo18 = true;
                break;
            case "Enemigo19":
                DatosPartida.Enemigo19 = true;
                break;
            case "Enemigo20":
                DatosPartida.Enemigo20 = true;
                break;
            case "Enemigo21":
                DatosPartida.Enemigo21 = true;
                break;
            case "Enemigo22":
                DatosPartida.Enemigo22 = true;
                break;
            case "Enemigo23":
                DatosPartida.Enemigo23 = true;
                break;
            case "Enemigo24":
                DatosPartida.Enemigo24 = true;
                break;
            case "Enemigo25":
                DatosPartida.Enemigo25 = true;
                break;
            case "Enemigo26":
                DatosPartida.Enemigo26 = true;
                break;
            case "Enemigo27":
                DatosPartida.Enemigo27 = true;
                break;
            case "Enemigo28":
                DatosPartida.Enemigo28 = true;
                break;
            case "Enemigo29":
                DatosPartida.Enemigo29 = true;
                break;
            case "Enemigo30":
                DatosPartida.Enemigo30 = true;
                break;
            case "Enemigo31":
                DatosPartida.Enemigo31 = true;
                break;
            case "Enemigo32":
                DatosPartida.Enemigo32 = true;
                break;
            case "Enemigo33":
                DatosPartida.Enemigo33 = true;
                break;
            case "Enemigo34":
                DatosPartida.Enemigo34 = true;
                break;
            case "Enemigo35":
                DatosPartida.Enemigo35 = true;
                break;
            case "Enemigo36":
                DatosPartida.Enemigo36 = true;
                break;
            case "Enemigo37":
                DatosPartida.Enemigo37 = true;
                break;
            case "Enemigo38":
                DatosPartida.Enemigo38 = true;
                break;
            case "Enemigo39":
                DatosPartida.Enemigo39 = true;
                break;
            case "Enemigo40":
                DatosPartida.Enemigo40 = true;
                break;
            case "Enemigo41":
                DatosPartida.Enemigo41 = true;
                break;
            case "Enemigo42":
                DatosPartida.Enemigo42 = true;
                break;
            case "Enemigo43":
                DatosPartida.Enemigo43 = true;
                break;
            case "Enemigo44":
                DatosPartida.Enemigo44 = true;
                break;
            case "Enemigo45":
                DatosPartida.Enemigo45 = true;
                break;
            case "Enemigo46":
                DatosPartida.Enemigo46 = true;
                break;
            case "Enemigo47":
                DatosPartida.Enemigo47= true;
                break;
            case "Enemigo48":
                DatosPartida.Enemigo48 = true;
                break;
            case "Enemigo49":
                DatosPartida.Enemigo49 = true;
                break;
            case "Enemigo50":
                DatosPartida.Enemigo50 = true;
                break;
            case "Enemigo51":
                DatosPartida.Enemigo51 = true;
                break;
            case "Enemigo52":
                DatosPartida.Enemigo52 = true;
                break;
        }
    }
}
