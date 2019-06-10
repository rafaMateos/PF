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
                        break;

                    case "espadaMedia":
                        SaludEnemigos.saludActual -= ConstantesEspadas.DANIOESPADAMEDIA;
                        Debug.Log(SaludEnemigos.saludActual);
                        GameObject.FindGameObjectWithTag("hitEnemigo").GetComponent<AudioSource>().Play();
                        break;

                    case "espadaLegendaria":
                        SaludEnemigos.saludActual -= ConstantesEspadas.DANIOESPADALEGENDARIA;
                        Debug.Log(SaludEnemigos.saludActual);
                        GameObject.FindGameObjectWithTag("hitEnemigo").GetComponent<AudioSource>().Play();
                        break;
                }
               
                
            }

        }
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

                /*Debemos devolver los valores por defecto a los enemigos ya que es un script general para todos ellos
                 Si no hicieramos esto los siguientes enemigos no tendrian salud ni velocidad ya que son diferentes GameObjects
                 y utilizamos la misma instacia de ellos*/
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
        }
    }
}
