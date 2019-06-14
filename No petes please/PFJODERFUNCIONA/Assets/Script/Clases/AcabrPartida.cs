using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AcabrPartida : MonoBehaviour
{
    //ESTO ES ASI. SI UNA CLASE PARA 1 VARIABLE. SI.. ASI DE TRISTE ES UNITY
    public static bool acabarpartida;

    /// <summary>
    /// Funcion update la cual se encarga de comprobar si la partida acabo
    /// </summary>
    private void Update()
    {
        if (acabarpartida) {
            acabarpartida = false;
            SceneManager.LoadScene("final");
        }
    }

}
