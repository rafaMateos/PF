using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PingPong2 : MonoBehaviour
{
    //Enmigo pin pong horizontal
    //Varibles de clase
    public float velocidad;
    public float longitudMovimiento;
    private float contador;
    private float posicionInicial;
    private float posicionActual;
    private float ultimaPosicion;


    // Start is called before the first frame update
    void Start()
    {
        posicionInicial = transform.position.y;
    }

    /// <summary>
    /// Metodo encargado de las colision con el juagdor
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionEnter2D(Collision2D collision)
    {
        ControladorSalud.DisminuirVida();
        GameObject.FindGameObjectWithTag("Player").transform.position =
            new Vector2(GameObject.FindGameObjectWithTag("Player").transform.position.x, GameObject.FindGameObjectWithTag("Player").transform.position.y + 5 * Time.deltaTime);
    }
   
    /// <summary>
    /// Metodo encargado del movimeto en rango del objeto
    /// </summary>
    void Update()
    {
        contador += Time.deltaTime * velocidad;
        transform.position = new Vector2(transform.position.x, posicionInicial + Mathf.PingPong(contador, longitudMovimiento));
        posicionActual = transform.position.y;
        

        ultimaPosicion = transform.position.y;
    }
}
