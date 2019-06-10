using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaludEnemigosEstaticos : MonoBehaviour
{
    private int saludMax;
    private int saludActual;
    public bool estaMuerto;
    // Start is called before the first frame update
    void Start()
    {
        saludMax = 2;
        saludActual = saludMax;
        estaMuerto = false;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ataque"))
        {
            if (saludActual > 0)
            {

                saludActual--;
                GameObject.FindGameObjectWithTag("hitEnemigo").GetComponent<AudioSource>().Play();
                Debug.Log(saludActual);
            }
        }
    }

    IEnumerator muerteEspera()
    {
      yield return new WaitForSeconds(0.8f);

        Destroy(gameObject);
       
    }
    // Update is called once per frame
    void Update()
    {
        if (saludActual <= 0)
        {

            GetComponent<Animator>().Play("muerte");
            StartCoroutine(muerteEspera());
        }
    }
}
