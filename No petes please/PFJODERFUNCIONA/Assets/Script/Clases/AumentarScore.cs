using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AumentarScore : MonoBehaviour
{

    public static int puntos = 20;


    public static void aumentarPuntos() {

        ScorePoint.puntos += puntos;

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
