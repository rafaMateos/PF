using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjetoMaximizador : MonoBehaviour
{
    //Variables de clase
    public Canvas canvasTiempo;
    public Text textoTiempo;
    public static float tiempo = 0;
    public Image imagen;
    public GameObject imagenBotas;
    public GameObject imagenVidaInfinita;
    public GameObject imagenManaInfinito;
    private bool esObjetoTocado = false;


    private void Start()
    {
        tiempo = 30;
        esObjetoTocado = false;
    }

    /// <summary>
    /// Metodo encargado de maximizar los atributos del jugador tras obtner el objeto 
    /// </summary>
    public void obtenerMax()
    {

          canvasTiempo.enabled = true;
            switch (tag) {
                case "botasRapidas":
                   
                    GameObject.FindGameObjectWithTag("Player").GetComponent<Movimiento>().velocidad = 10;
                    imagen.sprite = imagenBotas.GetComponent<SpriteRenderer>().sprite;
                    Destroy(gameObject);
                    esObjetoTocado = true;
                DatosInventario.soltarObjetosInventario(tag);
                    break;

                case "vidaInfinita":
                  
                    AtributosJugador.vidainfinita = true;
                    imagen.sprite = imagenVidaInfinita.GetComponent<SpriteRenderer>().sprite;
                    Destroy(gameObject);
                    esObjetoTocado = true;
                DatosInventario.soltarObjetosInventario(tag);
                break;

                case "manaInfinito":
                    AtributosJugador.manaInfinito = true;
                    imagen.sprite = imagenManaInfinito.GetComponent<SpriteRenderer>().sprite;
                    Destroy(gameObject);
                    esObjetoTocado = true;
                DatosInventario.soltarObjetosInventario(tag);
                break;
            }
        
    }

    /// <summary>
    /// Funcion update encargada de la gestion del tiempo
    /// </summary>
    private void Update()
    {
     
            tiempo -= Time.deltaTime;
            textoTiempo.text = "" + tiempo.ToString("f0");
           
        if (tiempo <= 0) {
            canvasTiempo.enabled = false;
            GameObject.FindGameObjectWithTag("Player").GetComponent<Movimiento>().velocidad = 6;
            AtributosJugador.vidainfinita = false;
            AtributosJugador.manaInfinito = false;

        }
    }

}
