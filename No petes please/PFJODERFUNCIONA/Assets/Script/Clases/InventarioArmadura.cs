using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventarioArmadura : MonoBehaviour
{

    private Canvas armadura;
    private bool estaMostrado;
    // Start is called before the first frame update
    void Start()
    {
        armadura = GetComponent<Canvas>();
        armadura.enabled = false;
        estaMostrado = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I) && !estaMostrado){
            armadura.enabled = true;
            estaMostrado = true;

        }
        else if (Input.GetKeyDown(KeyCode.I) && estaMostrado) {
            armadura.enabled = false;
            estaMostrado = false;
        }
    }
}
