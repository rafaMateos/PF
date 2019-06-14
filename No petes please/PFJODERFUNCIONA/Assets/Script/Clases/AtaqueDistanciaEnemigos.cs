using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtaqueDistanciaEnemigos : MonoBehaviour
{

   //Variables de script
    public float velocidad;
    GameObject player;   
    Rigidbody2D rb2d;    
    Vector3 objetivo, dir; 

    /// <summary>
    /// Funcion start la cual recogera los valores de las variables de script
    /// </summary>
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        rb2d = GetComponent<Rigidbody2D>();

       
        if (player != null)
        {
            objetivo = player.transform.position;
            dir = (objetivo - transform.position).normalized;
        }
    }

    /// <summary>
    /// Funcion FixedUpdate la cual ira actualizando la posicion del objeto instaciado por el enemigo
    /// </summary>
    void FixedUpdate()
    {
       
        if (objetivo != Vector3.zero)
        {
            rb2d.MovePosition(transform.position + (dir * velocidad) * Time.deltaTime);
        }
    }


    /// <summary>
    /// Evento trigguer el cual realizara el daño y pertinentes acciones consecutivas al jugador
    /// </summary>
    /// <param name="col"></param>
    void OnTriggerEnter2D(Collider2D col)
    {
       
        if (col.transform.tag == "Player" || col.transform.tag == "Ataque")
        {
            Destroy(gameObject);
            ControladorSalud.disminuirVidaPorFlecha();
            GameObject.FindGameObjectWithTag("hitJugador").GetComponent<AudioSource>().Play();
        }
    }

    /// <summary>
    /// Evento de colision 
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionEnter2D(Collision2D collision)
    {
          Destroy(gameObject);
 
    }

    /// <summary>
    /// Funcion la cual se encargara de destruir el objeto
    /// </summary>
    void destuirObjeto()
    {
        
        Destroy(gameObject);
    }
}
