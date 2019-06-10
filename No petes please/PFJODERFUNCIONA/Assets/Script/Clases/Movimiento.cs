using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float velocidad = 3F;
    Animator movAnimacion;
    Rigidbody2D caminarJugador;
    Vector2 posicion;

    CircleCollider2D ataque;
    public GameObject prefabAtaqueDistancia;
    private bool puedeAtacar;


    private void Start()
    {

        puedeAtacar = false;
        movAnimacion = GetComponent<Animator>();
        caminarJugador = GetComponent<Rigidbody2D>();

        ataque = transform.GetChild(0).GetComponent<CircleCollider2D>();

        ataque.enabled = false;

    }
    void Update()
    {
       posicion =
          new Vector2(Input.GetAxisRaw("Horizontal"),
          Input.GetAxisRaw("Vertical"));

        if (posicion != new Vector2(0, 0))
        {
            movAnimacion.SetFloat("movX", posicion.x);
            movAnimacion.SetFloat("movY", posicion.y);

            movAnimacion.SetBool("corriendo", true);
        }
        else
            movAnimacion.SetBool("corriendo", false);

        AnimatorStateInfo estadoAnim = movAnimacion.GetCurrentAnimatorStateInfo(0);
        bool esAtaque = estadoAnim.IsName("Ataque");

        if (Input.GetKeyDown("space") && !esAtaque) {
            movAnimacion.SetTrigger("ataque");
        }

        if (posicion != new Vector2(0, 0)) ataque.offset = new Vector2(posicion.x / 4f , posicion.y/4f);


        if (esAtaque) {

            float tiempoAtaque = estadoAnim.normalizedTime;
            if (tiempoAtaque > 0.33 && tiempoAtaque < 0.66)
            {
                ataque.enabled = true;
            }
            else {
                ataque.enabled = false;
            }    
        }

        atacarConMagia();
    }

    private void atacarConMagia() {

        if (Input.GetKeyDown(KeyCode.LeftAlt))
        {

        }
        else if (Input.GetKeyUp(KeyCode.LeftAlt) && AtributosJugador.tieneMana)
        {

                float direccion = Mathf.Atan2(movAnimacion.GetFloat("movY"), movAnimacion.GetFloat("movX")) * Mathf.Rad2Deg;
                GameObject ataquedistancia = Instantiate(prefabAtaqueDistancia, transform.position, Quaternion.AngleAxis(direccion, Vector3.forward));

                AtaqueDistancia ataque = prefabAtaqueDistancia.GetComponent<AtaqueDistancia>();
                ataque.direccionAtaque.x = movAnimacion.GetFloat("movX");
                ataque.direccionAtaque.y = movAnimacion.GetFloat("movY");
            if (!AtributosJugador.manaInfinito) {
                AtributosJugador.mana -= (float)0.1;
                
            }
                  

        }
    }

    IEnumerator esperarParaAtacar() {
        yield return new WaitForSeconds(3f);
        puedeAtacar = true;
    }

    private void FixedUpdate()
    {
        caminarJugador.MovePosition(caminarJugador.position + posicion * velocidad * Time.deltaTime);
    }
}
