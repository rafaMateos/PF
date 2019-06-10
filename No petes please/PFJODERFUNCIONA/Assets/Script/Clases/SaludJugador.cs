using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaludJugador : MonoBehaviour
{
    Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }

    private void Update()
    {
        if (AtributosJugador.vidas <= 0) {
            AtributosJugador.vidas = 0;
            SceneManager.LoadScene("Muerte");
            ScorePoint.puntos = 0;
        }
    }

}
