using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Level : MonoBehaviour
{
    //Variable de clase
    public InputField NombrePartidatexto;
  
    /// <summary>
    /// Metodo encargado de la carga de nivel cuando haya un nombre de partida
    /// </summary>
    /// <param name="nombreNivel"></param>
    public void cargarNivel(string nombreNivel) {

        DatosPartida.nombrePartida = NombrePartidatexto.text;
        if (!DatosPartida.nombrePartida.Equals("")) {
            SceneManager.LoadScene(nombreNivel);
        }
       
    }

    /// <summary>
    /// Metodo encargado de la carga final
    /// </summary>
    /// <param name="nombreNivel"></param>
    public static void CargarFINAL(string nombreNivel) {

        SceneManager.LoadScene(nombreNivel);
    }

    /// <summary>
    /// Metodo encargado de la carga pantalla muerte
    /// </summary>
    /// <param name="nombreNivel"></param>
    public void cargarNivelMuerte(string nombreNivel)
    {
      SceneManager.LoadScene(nombreNivel);
    }

    /// <summary>
    /// Metodo encargado de la carga cuando el usuario pulse en la partida
    /// </summary>
    /// <param name="nombreNivel"></param>
    public void cargarNivelCarga(string nombreNivel)
    {
        if (!CargarController.nombrePartida.Equals("") && !CargarController.nombrePartida.Equals("vacio")) {
            DatosPartida.nombrePartida = CargarController.nombrePartida;
            SceneManager.LoadScene(nombreNivel);
        }
      
        
    }
}
