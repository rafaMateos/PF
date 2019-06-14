using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class llave : MonoBehaviour
{
    //Variables de clase
    public static bool tieneLaLlave = false;
    public static List<SpriteRenderer> lista = new List<SpriteRenderer>();
    GameObject llaves;
    SpriteRenderer spriteLLave;
    AudioSource audio;

    private void Start()
    {
        spriteLLave = GetComponent<SpriteRenderer>();
        audio = GetComponent<AudioSource>();

     
    }

    /// <summary>
    /// Evento trigguer de colision gestor de las llaves que tenemos
    /// </summary>
    /// <param name="collision"></param>
    private void OnTriggerEnter2D(Collider2D collision)
    {

        lista.Add(GetComponent<SpriteRenderer>());
        GetComponent<BoxCollider2D>().enabled = false;
        tieneLaLlave = true;
        spriteLLave.enabled = false;
        audio.Play();

        for (int i = 0; i < lista.Count; i++) {
            if (lista.Count > 0) {

                AtributosJugador.tieneLlave = true;
            }
           
        }
    }


}
