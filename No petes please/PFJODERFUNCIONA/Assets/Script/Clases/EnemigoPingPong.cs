using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class EnemigoPingPong : MonoBehaviour
{
    //Variables de clase
    public float velocidad;
    public float longitudMovimiento;
    private float contador;
    private float posicionInicial;
    private float posicionActual;
    private float ultimaPosicion;
   

    // Start is called before the first frame update
    void Start()
    {
        posicionInicial = transform.position.x;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        ControladorSalud.DisminuirVida();
        GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>()
            .MovePosition(new Vector2(GameObject.FindGameObjectWithTag("Player").transform.position.x + 5,GameObject.FindGameObjectWithTag("Player").transform.position.y + 5));
          
    }
    // Update is called once per frame
    void Update()
    {
        contador += Time.deltaTime * velocidad;
        transform.position = new Vector2(Mathf.PingPong(contador, longitudMovimiento) + posicionInicial , transform.position.y);
        posicionActual = transform.position.x;
        if (posicionActual < ultimaPosicion) {
            //transform.localScale = new Vector3(1, 1,1);
            GetComponent<SpriteRenderer>().flipX = true;
        }
        if (posicionActual > ultimaPosicion) {
            //transform.localScale = new Vector3(-1, 1,1);
            GetComponent<SpriteRenderer>().flipX = false;
           

        }

        ultimaPosicion = transform.position.x;
    }
}
