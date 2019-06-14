using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConjuntoEnemigos : MonoBehaviour
{
    /// <summary>
    /// Varibales de script
    /// </summary>
    private SpriteRenderer Jugador;
    private SpriteRenderer Enemigos;
    private GameObject ObjetoJugador;
    private GameObject material;
    private GameObject Gestor;
    public GameObject[] EnmigosArray;
    public bool yaEsJefe;

   
    /// <summary>
    /// Obtenemos valores para variables
    /// </summary>
    void Start()
    {
        ObjetoJugador = GameObject.Find("Character");
        Jugador = ObjetoJugador.GetComponent<SpriteRenderer>();
        Enemigos = GetComponent<SpriteRenderer>();
        material = GameObject.FindGameObjectWithTag("Fade");
      
        Gestor = GameObject.FindGameObjectWithTag("Management");
    }

    /// <summary>
    /// Evento de entrada colision
    /// </summary>
    /// <param name="collision"></param>
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Jugador.sortingOrder = 1;
            Enemigos.sortingOrder = 2;
        }
    }

    /// <summary>
    /// Corrutina de desaparicion
    /// </summary>
    /// <returns></returns>
    IEnumerator desaparecer()
    {
        for (float i = 0f; i < 1f; i += 2.6f)
        {
            yield return new WaitForSeconds(2.6f);
        }
        Destroy(gameObject);
    }

    /// <summary>
    /// Corrutina para obtener los enemigos
    /// </summary>
    /// <returns></returns>
    IEnumerator obtnerEnemigos()
    {
        for (float i = 0f; i < 1f; i = i + 0.02f)
        {
            yield return new WaitForSeconds(0.0001f);
        }
        EnmigosArray = GameObject.FindGameObjectsWithTag("Enemigos");
   
        Destroy(gameObject);
    }

    /// <summary>
    /// Evento de colision
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionEnter2D(Collision2D collision)
    {
     
            if (yaEsJefe)
            {
                StartCoroutine(obtnerEnemigos());
            }
            else
            {
                StartCoroutine(desaparecer());
            }
        
    }
}
