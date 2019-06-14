using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaludJefes : MonoBehaviour
{
    //Variables de script
    public int vida = 2;
    private bool acabado;

    /// <summary>
    /// Gestor de colisiones jefe para disminuir vida
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Ataque")) {

            vida--;
            GameObject.FindGameObjectWithTag("hitEnemigo").GetComponent<AudioSource>().Play();
        }
    }

    /// <summary>
    /// Gestor de trigguer jefe para ataques jugador
    /// </summary>
    /// <param name="collision"></param>
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ataque"))
        {
            vida--;
            GameObject.FindGameObjectWithTag("hitEnemigo").GetComponent<AudioSource>().Play();
        }
        if (vida <= 0) {
            if (tag.Equals("JefeFinal"))
            {
                GetComponent<Animator>().Play("muerte");
                StartCoroutine(matarJefeFinal());
            }
            else {
                GetComponent<Animator>().Play("muerte");
                StartCoroutine(matarJefe());
            }
           
            
        }
    }

    /// <summary>
    /// Corrutina encargada de matar a los jefes
    /// </summary>
    /// <returns></returns>
    IEnumerator matarJefe() {
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
       
    }
    /// <summary>
    /// Corrutina encargada de matar al jefe final
    /// </summary>
    /// <returns></returns>
    IEnumerator matarJefeFinal()
    {
        yield return new WaitForSeconds(1f);
        AcabrPartida.acabarpartida = true;
        Destroy(gameObject);

    }

}
