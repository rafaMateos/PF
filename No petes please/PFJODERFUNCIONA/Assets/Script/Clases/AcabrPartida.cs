using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AcabrPartida : MonoBehaviour
{
    //ESTO ES ASI. SI UNA CLASE PARA 1 VARIABLE. SI.. ASI DE TRISTE ES UNITY
    public static bool acabarpartida;

    private void Update()
    {
        if (acabarpartida) {

            SceneManager.LoadScene("final");
        }
    }

}
