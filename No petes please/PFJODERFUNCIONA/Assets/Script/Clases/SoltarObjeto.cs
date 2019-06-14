using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoltarObjeto : MonoBehaviour
{
    //Variables de clase
    public GameObject item;
    private Transform posJug;
   

    void Start()
    {
        posJug = GameObject.FindGameObjectWithTag("Player").transform;
    }

    //Metodo encargado de soltar el objeto y volver a instanciarlo
    public void dropObjeto() {

        Vector2 pos = new Vector2(posJug.position.x, posJug.position.y + 1);
        Instantiate(item, pos, Quaternion.identity);
        DatosInventario.soltarObjetosInventario(item.tag);
    }

   
}
