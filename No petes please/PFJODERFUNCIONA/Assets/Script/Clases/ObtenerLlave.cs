using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObtenerLlave : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {

            switch (tag)
            {
                case "llave1":
                    AtributosLlaves.llave1 = true;
                    Destroy(gameObject);
                    break;

                case "llave2":
                    AtributosLlaves.llave2 = true;
                    Destroy(gameObject);
                    break;

                case "llave3":
                    AtributosLlaves.llave3 = true;
                    Destroy(gameObject);
                    break;

                case "llave4":
                    AtributosLlaves.llave4 = true;
                    Destroy(gameObject);
                    break;

                case "llave6":
                    AtributosLlaves.llave6 = true;
                    Destroy(gameObject);
                    break;
            }
        }
    }
}
