using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour
{
    //Varibles de clase
    public float visionEnemigos;
    public float radioAtaque;
    public float velocidad;
    private float velocidadMax;

    GameObject Jugador;
    Vector3 posicionInicial, Objetivo;
    Animator animaciones;
    Rigidbody2D rb2d;


    /// <summary>
    /// Evento de colision
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionEnter2D(Collision2D collision)
    {
        velocidad = 0;
        animaciones.Play("andando", -1, 0);
        animaciones.Play("ataque");

    }

    /// <summary>
    /// Evento de salida de colision
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionExit2D(Collision2D collision)
    {
        animaciones.Play("ataque", -1, 0);
        animaciones.Play("andando");
        velocidad = velocidadMax;
    }


    /// <summary>
    /// Obtnemos el estado de las variables en el metodo satrt
    /// </summary>
    void Start()
    {
        animaciones = GetComponent<Animator>();
        velocidadMax = velocidad;
     
        Jugador = GameObject.FindGameObjectWithTag("Player");
        posicionInicial = transform.position;
        rb2d = GetComponent<Rigidbody2D>();

    

    }

    /// <summary>
    /// Gestionamos frame a frame el estado , posicion de los enemigos
    /// </summary>
    void Update()
    {

        if (transform.position.x > Jugador.transform.position.x)
        {
            GetComponent<SpriteRenderer>().flipX = true;
        }
        else
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }
     
        Objetivo = posicionInicial;

      
        RaycastHit2D hit = Physics2D.Raycast(
            transform.position,
            Jugador.transform.position - transform.position,
            visionEnemigos,
            1 << LayerMask.NameToLayer("Default")
        
        );

      
        Vector3 forward = transform.TransformDirection(Jugador.transform.position - transform.position);
        Debug.DrawRay(transform.position, forward, Color.red);

       
        if (hit.collider != null)
        {
            if (hit.collider.tag == "Player")
            {
                Objetivo = Jugador.transform.position;
            }
        }

        float distance = Vector3.Distance(Objetivo, transform.position);
        Vector3 dir = (Objetivo - transform.position).normalized;

       
        if (Objetivo != posicionInicial && distance < radioAtaque)
        {
            //Nothing else...
        }
        else
        {
            rb2d.MovePosition(transform.position + dir * velocidad * Time.deltaTime);
        }
        if (Objetivo == posicionInicial && distance < 0.05f)
        {
            transform.position = posicionInicial;
        }
        Debug.DrawLine(transform.position, Objetivo, Color.green);
    }

   


   




}
