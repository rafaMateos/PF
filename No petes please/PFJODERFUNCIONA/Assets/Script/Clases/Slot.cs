using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot : MonoBehaviour
{
    private Inventario inventario;
    public int i;


    private void Start()
    {
        inventario = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventario>();
    }

    private void Update()
    {
        if (transform.childCount <= 0) {

            inventario.esCompleto[i] = false;
        }
    }
    public void QuitarObjeto() {

        foreach (Transform child in transform) {
            child.GetComponent<SoltarObjeto>().dropObjeto();
            GameObject.Destroy(child.gameObject);
        }
    }
}
