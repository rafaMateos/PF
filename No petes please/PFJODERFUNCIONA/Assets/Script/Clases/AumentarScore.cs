using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AumentarScore : MonoBehaviour
{
    //Variables de script
    public static int puntos = 20;

    /// <summary>
    /// Metodo encargado del aumento de monedas
    /// </summary>
    public static void aumentarPuntos() {

        ScorePoint.puntos += puntos;

    }

   
}
