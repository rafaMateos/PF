using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestosColisionesJefes : MonoBehaviour
{
    //Variables de clase
    private BoxCollider2D colisionActivacion;
    public BoxCollider2D coliderNoPasar;
    public static bool puedeAtacarJefe;
  
    //Comentario para explicacion clase: Gestionara que si te metes en una habitacion de jefe no puedas volver
    void Start()
    {
        colisionActivacion = GetComponent<BoxCollider2D>();
        coliderNoPasar.enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        puedeAtacarJefe = true;
        coliderNoPasar.enabled = true;
    }
    
}
