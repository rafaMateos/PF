using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Dialog : MonoBehaviour
{
    //variables de script
    private AudioSource audio;
    public Canvas canvas;
    public TextMeshProUGUI textoMostrar;
    public string[] frases;
    private int indice;
    Movimiento m = new Movimiento();

    /// <summary>
    /// Coorutina para recorrer el dialogo
    /// </summary>
    /// <returns></returns>
    IEnumerator recorrerDialogo() {

        GameObject.FindGameObjectWithTag("Player").GetComponent<Animator>().enabled = false;
        GameObject.FindGameObjectWithTag("Player").GetComponent<Movimiento>().enabled = false;
        foreach (char letra in frases[indice].ToCharArray()) {
            textoMostrar.text += letra;
            yield return new WaitForSeconds(0.03f);
        }
        GameObject.FindGameObjectWithTag("Player").GetComponent<Animator>().enabled = true;
        GameObject.FindGameObjectWithTag("Player").GetComponent<Movimiento>().enabled = true;
    }

    private void Start()
    {
       
        audio = GetComponent<AudioSource>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

      
        textoMostrar.text = "";
        audio.Play();
        canvas.enabled = true;
        StartCoroutine(recorrerDialogo());
        textoMostrar.text = "";
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        canvas.enabled = false;
        textoMostrar.text = "";
        audio.Stop();
       
    }

    public void proximaFrase() {

        if (indice < frases.Length)
        {
            indice++;
            textoMostrar.text = "";
            StartCoroutine(recorrerDialogo());
        }
        else {
            
            textoMostrar.text = "";
            canvas.enabled = false;
        }

    }

   
}
