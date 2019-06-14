using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaludJugador : MonoBehaviour
{
    //Variables de clase
    Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    /// <summary>
    /// Metodo update encargado de matar al jugador 
    /// </summary>
    private void Update()
    {
        if (AtributosJugador.vidas <= 0) {
            AtributosJugador.vidas = 0;
            SceneManager.LoadScene("Muerte");
            ScorePoint.puntos = 0;
        }
    }

}
