using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruir : MonoBehaviour
{

    GameObject dinero;
    // Start is called before the first frame update
    void Start()
    {
        dinero = GetComponent<GameObject>();
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) {
            AumentarScore.aumentarPuntos();
            GetComponent<BoxCollider2D>().enabled = false;
            GetComponent<SpriteRenderer>().enabled = false;
            CambiarEstado();

        }

    }


    private void CambiarEstado() {

        switch (tag) {

            case "moneda1":
                DatosPartida.moneda1 = true;
                break;

            case "moneda2":
                DatosPartida.moneda2 = true;
                break;

            case "moneda3":
                DatosPartida.moneda3 = true;
                break;

            case "moneda4":
                DatosPartida.moneda4 = true;
                break;

            case "moneda5":
                DatosPartida.moneda5 = true;
                break;

            case "moneda6":
                DatosPartida.moneda6 = true;
                break;

            case "moneda7":
                DatosPartida.moneda7 = true;
                break;

            case "moneda8":
                DatosPartida.moneda8 = true;
                break;


        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
