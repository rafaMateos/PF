using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtaqueJefe : MonoBehaviour
{
    //Varibles de script
    private bool esAtaqueJefe;

    /// <summary>
    /// Funcion awake encargada de la repeticion del metodo 
    /// </summary>
    private void Awake()
    {
        InvokeRepeating("ataqueJefe", 1f, 1f);
    }

    /// <summary>
    /// Funcion start y encargada de la asignacion valores a variables
    /// </summary>
    private void Start()
    {
        esAtaqueJefe = false;
    }

 
    private void Update()
    {
        esAtaqueJefe = GetComponent<Animator>().GetBool("atacando");
    }

    /// <summary>
    /// Funcion que gestionara cuando debe atacar el jefe
    /// </summary>
    void ataqueJefe()
    {

        if (esAtaqueJefe)
            ControladorSalud.DisminuirVida();
    }
}
