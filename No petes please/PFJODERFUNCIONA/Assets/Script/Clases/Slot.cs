using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot : MonoBehaviour
{
    //Varibales de clase
    private Inventario inventario;
    public int i;

    private void Start()
    {
        inventario = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventario>();
    }
    /// <summary>
    /// Metodo encargado de quitar posiciones completas del inventario
    /// </summary>
    private void Update()
    {
        if (transform.childCount <= 0) {
            inventario.esCompleto[i] = false;
        }
    }

    /// <summary>
    /// Metodo encargado de destruir el gameObjet del iventario tras uso o soltarlo
    /// </summary>
    public void QuitarObjeto() {

        foreach (Transform child in transform) {
            child.GetComponent<SoltarObjeto>().dropObjeto();
            GameObject.Destroy(child.gameObject);
        }
    }
}
