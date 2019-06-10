using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaludEnemigos : MonoBehaviour
{

    private int saludMax;
    public static int saludActual; 

    private void Start()
    {
        saludMax = 10;
        saludActual = saludMax;
    }


   
}
