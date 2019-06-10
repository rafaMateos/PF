using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestorAtaquesJefe : MonoBehaviour
{
    public GameObject ataquePrefab;
    private void Awake()
    {
        InvokeRepeating("atacarJugador", 0.5f, 0.5f);
    }

    void atacarJugador()
    {
        if(GestosColisionesJefes.puedeAtacarJefe)
        Instantiate(ataquePrefab ,transform.position,Quaternion.AngleAxis(0f,Vector3.forward));
    }
   
}
