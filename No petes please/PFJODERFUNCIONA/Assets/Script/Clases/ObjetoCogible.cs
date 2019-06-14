using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoCogible : MonoBehaviour
{

    // Variables de clase
    public static Inventario inventario;
    public GameObject Item;
    

    private void Start()
    {
        inventario = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventario>();

    }

    /// <summary>
    /// Evento trigguer para colision de objeto
    /// </summary>
    /// <param name="collision"></param>
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Player")) {

            instanciarInven();
        }
    }

    /// <summary>
    /// Metodo encargado de la instanciacion del objeto en el inventario
    /// </summary>
    public void instanciarInven() {
        for (int i = 0; i < inventario.slots.Length; i++)
        {
            if (!inventario.esCompleto[i])
            {
                DatosInventario.añadirObjetoAlInventario(Item.tag);
                inventario.esCompleto[i] = true;
                Instantiate(Item, inventario.slots[i].transform, false);
                Destroy(gameObject);
                break;
            }
        }
    }

    /// <summary>
    /// Metodo encargado de la instanciacion del objeto en el inventario interno
    /// </summary>
    public void instanciarInven(GameObject item)
    {
        bool acabado = false;
        for (int i = 0; i < inventario.slots.Length && !acabado; i++)
        {
            if (!inventario.esCompleto[i])
            {
                DatosInventario.añadirObjetoAlInventario(item.tag);
                inventario.esCompleto[i] = true;
                Instantiate(item, inventario.slots[i].transform, false);
               
                acabado = true;
            }
        }
    }
}
