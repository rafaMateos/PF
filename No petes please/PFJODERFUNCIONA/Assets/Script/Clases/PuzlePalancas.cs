using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzlePalancas : MonoBehaviour
{

    private string[] palancas;
    private string[] palancas2;
    public string[] patron;
    public string[] patron2;
    public GameObject puertaAbrir;
    public GameObject puertaAbrir2;
    public GameObject llaveAbierta;
    public GameObject llaveCerrada;
    private bool puerta1;
    private bool puerta2;

    private void Start()
    {
        Debug.Log("hola");
        palancas = new string[5];
        palancas2 = new string[5];
        for (int i = 0; i < palancas.Length; i++) {
            palancas[i] = "i"; 
            palancas2[i] = "i"; 
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && AtributosPuzle.estaEnPalanca)
        {
            obtenerPosicionPalancas();

            if (palancas[0].Equals(patron[0]) && palancas[1].Equals(patron[1])
                && palancas[2].Equals(patron[2]) && palancas[3].Equals(patron[3])
                && palancas[4].Equals(patron[4]))
            {
                if (puertaAbrir != null)
                {
                    puerta1 = true;
                    puertaAbrir.GetComponent<BoxCollider2D>().enabled = false;
                    puertaAbrir.GetComponent<Animator>().Play("parar");
                    StartCoroutine(acabarConObjeto());
                }
            } 

                if (palancas2[0].Equals(patron2[0]) && palancas2[1].Equals(patron2[1])
               && palancas2[2].Equals(patron2[2]) && palancas2[3].Equals(patron2[3])
               && palancas2[4].Equals(patron2[4]))
                {
                    if (puertaAbrir2 != null) {
                    puerta2 = true;
                        puertaAbrir2.GetComponent<BoxCollider2D>().enabled = false;
                        puertaAbrir2.GetComponent<Animator>().Play("parar");
                        StartCoroutine(acabarConObjeto());
                    }
                    
                   
                }
            
        }
    }

    IEnumerator acabarConObjeto()
    {
        yield return new WaitForSeconds(1f);
        if (puerta1)
            Destroy(puertaAbrir);
        if (puerta2)
            Destroy(puertaAbrir2);
    }
    void obtenerPosicionPalancas() {

        switch (AtributosPuzle.ultimaPalanca)
        {

            case "palanca1":

                if (palancas[0].Equals("i"))
                {
                    palancas[0] = "d";
                    GameObject.FindGameObjectWithTag(AtributosPuzle.ultimaPalanca).GetComponent<SpriteRenderer>().sprite =
                        llaveAbierta.GetComponent<SpriteRenderer>().sprite;
                    GameObject.FindGameObjectWithTag(AtributosPuzle.ultimaPalanca).GetComponent<AudioSource>().Play();
                }
                else
                {
                    palancas[0] = "i";
                    GameObject.FindGameObjectWithTag(AtributosPuzle.ultimaPalanca).GetComponent<SpriteRenderer>().sprite =
                      llaveCerrada.GetComponent<SpriteRenderer>().sprite;
                    GameObject.FindGameObjectWithTag(AtributosPuzle.ultimaPalanca).GetComponent<AudioSource>().Play();
                }
                break;

            case "palanca2":

                if (palancas[1].Equals("i"))
                {
                    palancas[1] = "d";
                    GameObject.FindGameObjectWithTag(AtributosPuzle.ultimaPalanca).GetComponent<SpriteRenderer>().sprite =
                        llaveAbierta.GetComponent<SpriteRenderer>().sprite;
                    GameObject.FindGameObjectWithTag(AtributosPuzle.ultimaPalanca).GetComponent<AudioSource>().Play();
                }
                else
                {
                    palancas[1] = "i";
                    GameObject.FindGameObjectWithTag(AtributosPuzle.ultimaPalanca).GetComponent<SpriteRenderer>().sprite =
                      llaveCerrada.GetComponent<SpriteRenderer>().sprite;
                    GameObject.FindGameObjectWithTag(AtributosPuzle.ultimaPalanca).GetComponent<AudioSource>().Play();
                }
                break;

            case "palanca3":

                if (palancas[2].Equals("i"))
                {
                    palancas[2] = "d";
                    GameObject.FindGameObjectWithTag(AtributosPuzle.ultimaPalanca).GetComponent<SpriteRenderer>().sprite =
                        llaveAbierta.GetComponent<SpriteRenderer>().sprite;
                    GameObject.FindGameObjectWithTag(AtributosPuzle.ultimaPalanca).GetComponent<AudioSource>().Play();
                }
                else
                {
                    palancas[2] = "i";
                    GameObject.FindGameObjectWithTag(AtributosPuzle.ultimaPalanca).GetComponent<SpriteRenderer>().sprite =
                      llaveCerrada.GetComponent<SpriteRenderer>().sprite;
                    GameObject.FindGameObjectWithTag(AtributosPuzle.ultimaPalanca).GetComponent<AudioSource>().Play();
                }
                break;

            case "palanca4":

                if (palancas[3].Equals("i"))
                {
                    palancas[3] = "d";
                    GameObject.FindGameObjectWithTag(AtributosPuzle.ultimaPalanca).GetComponent<SpriteRenderer>().sprite =
                        llaveAbierta.GetComponent<SpriteRenderer>().sprite;
                    GameObject.FindGameObjectWithTag(AtributosPuzle.ultimaPalanca).GetComponent<AudioSource>().Play();
                }
                else
                {
                    palancas[3] = "i";
                    GameObject.FindGameObjectWithTag(AtributosPuzle.ultimaPalanca).GetComponent<SpriteRenderer>().sprite =
                      llaveCerrada.GetComponent<SpriteRenderer>().sprite;
                    GameObject.FindGameObjectWithTag(AtributosPuzle.ultimaPalanca).GetComponent<AudioSource>().Play();
                }
                break;

            case "palanca5":

                if (palancas[4].Equals("i"))
                {
                    palancas[4] = "d";
                    GameObject.FindGameObjectWithTag(AtributosPuzle.ultimaPalanca).GetComponent<SpriteRenderer>().sprite =
                        llaveAbierta.GetComponent<SpriteRenderer>().sprite;
                    GameObject.FindGameObjectWithTag(AtributosPuzle.ultimaPalanca).GetComponent<AudioSource>().Play();
                }
                else
                {
                    palancas[4] = "i";
                    GameObject.FindGameObjectWithTag(AtributosPuzle.ultimaPalanca).GetComponent<SpriteRenderer>().sprite =
                      llaveCerrada.GetComponent<SpriteRenderer>().sprite;
                    GameObject.FindGameObjectWithTag(AtributosPuzle.ultimaPalanca).GetComponent<AudioSource>().Play();
                }
                break;

            case "palanca6":

                if (palancas2[0].Equals("i"))
                {
                    palancas2[0] = "d";
                    GameObject.FindGameObjectWithTag(AtributosPuzle.ultimaPalanca).GetComponent<SpriteRenderer>().sprite =
                        llaveAbierta.GetComponent<SpriteRenderer>().sprite;
                    GameObject.FindGameObjectWithTag(AtributosPuzle.ultimaPalanca).GetComponent<AudioSource>().Play();
                }
                else
                {
                    palancas2[0] = "i";
                    GameObject.FindGameObjectWithTag(AtributosPuzle.ultimaPalanca).GetComponent<SpriteRenderer>().sprite =
                      llaveCerrada.GetComponent<SpriteRenderer>().sprite;
                    GameObject.FindGameObjectWithTag(AtributosPuzle.ultimaPalanca).GetComponent<AudioSource>().Play();
                }
                break;

            case "palanca7":

                if (palancas2[1].Equals("i"))
                {
                    palancas2[1] = "d";
                    GameObject.FindGameObjectWithTag(AtributosPuzle.ultimaPalanca).GetComponent<SpriteRenderer>().sprite =
                        llaveAbierta.GetComponent<SpriteRenderer>().sprite;
                    GameObject.FindGameObjectWithTag(AtributosPuzle.ultimaPalanca).GetComponent<AudioSource>().Play();
                }
                else
                {
                    palancas2[1] = "i";
                    GameObject.FindGameObjectWithTag(AtributosPuzle.ultimaPalanca).GetComponent<SpriteRenderer>().sprite =
                      llaveCerrada.GetComponent<SpriteRenderer>().sprite;
                    GameObject.FindGameObjectWithTag(AtributosPuzle.ultimaPalanca).GetComponent<AudioSource>().Play();
                }
                break;

            case "palanca8":

                if (palancas2[2].Equals("i"))
                {
                    palancas2[2] = "d";
                    GameObject.FindGameObjectWithTag(AtributosPuzle.ultimaPalanca).GetComponent<SpriteRenderer>().sprite =
                        llaveAbierta.GetComponent<SpriteRenderer>().sprite;
                    GameObject.FindGameObjectWithTag(AtributosPuzle.ultimaPalanca).GetComponent<AudioSource>().Play();
                }
                else
                {
                    palancas2[2] = "i";
                    GameObject.FindGameObjectWithTag(AtributosPuzle.ultimaPalanca).GetComponent<SpriteRenderer>().sprite =
                      llaveCerrada.GetComponent<SpriteRenderer>().sprite;
                    GameObject.FindGameObjectWithTag(AtributosPuzle.ultimaPalanca).GetComponent<AudioSource>().Play();
                }
                break;

            case "palanca9":

                if (palancas2[3].Equals("i"))
                {
                    palancas2[3] = "d";
                    GameObject.FindGameObjectWithTag(AtributosPuzle.ultimaPalanca).GetComponent<SpriteRenderer>().sprite =
                        llaveAbierta.GetComponent<SpriteRenderer>().sprite;
                    GameObject.FindGameObjectWithTag(AtributosPuzle.ultimaPalanca).GetComponent<AudioSource>().Play();
                }
                else
                {
                    palancas2[3] = "i";
                    GameObject.FindGameObjectWithTag(AtributosPuzle.ultimaPalanca).GetComponent<SpriteRenderer>().sprite =
                      llaveCerrada.GetComponent<SpriteRenderer>().sprite;
                    GameObject.FindGameObjectWithTag(AtributosPuzle.ultimaPalanca).GetComponent<AudioSource>().Play();
                }
                break;

            case "palanca10":

                if (palancas2[4].Equals("i"))
                {
                    palancas2[4] = "d";
                    GameObject.FindGameObjectWithTag(AtributosPuzle.ultimaPalanca).GetComponent<SpriteRenderer>().sprite =
                        llaveAbierta.GetComponent<SpriteRenderer>().sprite;
                    GameObject.FindGameObjectWithTag(AtributosPuzle.ultimaPalanca).GetComponent<AudioSource>().Play();
                }
                else
                {
                    palancas2[4] = "i";
                    GameObject.FindGameObjectWithTag(AtributosPuzle.ultimaPalanca).GetComponent<SpriteRenderer>().sprite =
                      llaveCerrada.GetComponent<SpriteRenderer>().sprite;
                    GameObject.FindGameObjectWithTag(AtributosPuzle.ultimaPalanca).GetComponent<AudioSource>().Play();
                }
                break;
        }
    }
}
