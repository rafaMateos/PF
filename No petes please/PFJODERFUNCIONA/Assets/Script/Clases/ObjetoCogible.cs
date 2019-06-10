using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoCogible : MonoBehaviour
{

    private Inventario inventario;
    public GameObject Item;
    

    private void Start()
    {
        inventario = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventario>();

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Player")) {

            for (int i = 0; i < inventario.slots.Length; i++) {

                if (!inventario.esCompleto[i]) {

                    inventario.esCompleto[i] = true;
                    Instantiate(Item,inventario.slots[i].transform, false);
                    Destroy(gameObject);
                    break;
                }
            }
        }
    }
}
