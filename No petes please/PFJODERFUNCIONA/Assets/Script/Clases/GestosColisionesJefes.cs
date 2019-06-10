using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestosColisionesJefes : MonoBehaviour
{

    private BoxCollider2D colisionActivacion;
    public BoxCollider2D coliderNoPasar;
    public static bool puedeAtacarJefe;
    // Start is called before the first frame update

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
