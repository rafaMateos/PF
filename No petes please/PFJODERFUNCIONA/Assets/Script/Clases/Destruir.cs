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

            case "moneda9":
                DatosPartida.moneda9 = true;
                break;

            case "moneda10":
                DatosPartida.moneda10 = true;
                break;

            case "moneda11":
                DatosPartida.moneda11 = true;
                break;

            case "moneda12":
                DatosPartida.moneda12 = true;
                break;

            case "moneda13":
                DatosPartida.moneda13 = true;
                break;

            case "moneda14":
                DatosPartida.moneda14 = true;
                break;

            case "moneda15":
                DatosPartida.moneda15 = true;
                break;

            case "moneda16":
                DatosPartida.moneda16 = true;
                break;

            case "moneda17":
                DatosPartida.moneda17 = true;
                break;

            case "moneda18":
                DatosPartida.moneda18 = true;
                break;

            case "moneda19":
                DatosPartida.moneda19 = true;
                break;

            case "moneda20":
                DatosPartida.moneda20 = true;
                break;

            case "moneda21":
                DatosPartida.moneda21 = true;
                break;

            case "moneda22":
                DatosPartida.moneda22 = true;
                break;

            case "moneda23":
                DatosPartida.moneda23 = true;
                break;

            case "moneda24":
                DatosPartida.moneda24 = true;
                break;

            case "moneda25":
                DatosPartida.moneda25 = true;
                break;

            case "moneda26":
                DatosPartida.moneda26 = true;
                break;

            case "moneda27":
                DatosPartida.moneda27 = true;
                break;

            case "moneda28":
                DatosPartida.moneda28 = true;
                break;

            case "moneda29":
                DatosPartida.moneda29 = true;
                break;

            case "moneda30":
                DatosPartida.moneda30 = true;
                break;

            case "moneda31":
                DatosPartida.moneda31 = true;
                break;

            case "moneda32":
                DatosPartida.moneda32 = true;
                break;

            case "moneda33":
                DatosPartida.moneda33 = true;
                break;

            case "moneda34":
                DatosPartida.moneda34 = true;
                break;


        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
