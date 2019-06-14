using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtaqueEnemigoJefe : MonoBehaviour
{
    //Variables de script
    public GameObject prefabAtaqueDistancia;
    private Animator animaciones;
    private AudioSource sonido;

    /// <summary>
    /// Metodo awake el cual se encargara de gestionar la repiticon del ataque del jefe
    /// </summary>
    private void Awake()
    {
        InvokeRepeating("ataquedistancia", 4f, 4f);
        animaciones = GetComponent<Animator>();
        sonido = GetComponent<AudioSource>();
    }
    /// <summary>
    /// Funcion la cual se encargara de realizar el ataque sobre el personage
    /// </summary>
    private void ataquedistancia() {

        animaciones.enabled = true;
        float direccion = Mathf.Atan2(transform.position.y, transform.position.x) * Mathf.Rad2Deg;
        GameObject ataquedistancia = Instantiate(prefabAtaqueDistancia, transform.position, Quaternion.AngleAxis(direccion, Vector3.forward));

        AtaqueDistancia ataque = prefabAtaqueDistancia.GetComponent<AtaqueDistancia>();
        ataque.direccionAtaque.x = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>().transform.position.x;

        ataque.direccionAtaque.y = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>().transform.position.y;
        animaciones.Play("atack");
        animaciones.enabled = false;
        sonido.Play();

        
    }
}
