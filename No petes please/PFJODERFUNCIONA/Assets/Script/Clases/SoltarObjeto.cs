using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoltarObjeto : MonoBehaviour
{

    public GameObject item;
    private Transform posJug;
    // Start is called before the first frame update
    void Start()
    {
        posJug = GameObject.FindGameObjectWithTag("Player").transform;
    }

    public void dropObjeto() {

        Vector2 pos = new Vector2(posJug.position.x, posJug.position.y + 1);
        Instantiate(item, pos, Quaternion.identity);
        DatosInventario.soltarObjetosInventario(item.tag);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
