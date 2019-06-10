using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaludJefes : MonoBehaviour
{

    public int vida = 2;
    private bool acabado;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Ataque")) {

            vida--;
            GameObject.FindGameObjectWithTag("hitEnemigo").GetComponent<AudioSource>().Play();
        }
    }

    private void Update()
    {
        
    }

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

    

    IEnumerator matarJefe() {
        yield return new WaitForSeconds(1f);
        
        Destroy(gameObject);
       
    }

    IEnumerator matarJefeFinal()
    {
        yield return new WaitForSeconds(1f);
        AcabrPartida.acabarpartida = true;
        Destroy(gameObject);

    }

}
