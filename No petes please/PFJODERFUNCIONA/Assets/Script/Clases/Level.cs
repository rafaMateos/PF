using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Level : MonoBehaviour
{

    public InputField NombrePartidatexto;
  

    public void cargarNivel(string nombreNivel) {

        DatosPartida.nombrePartida = NombrePartidatexto.text;
        if (!DatosPartida.nombrePartida.Equals("")) {
            SceneManager.LoadScene(nombreNivel);
        }
       
    }

    public static void CargarFINAL(string nombreNivel) {

        SceneManager.LoadScene(nombreNivel);
    }

    public void cargarNivelMuerte(string nombreNivel)
    {
      SceneManager.LoadScene(nombreNivel);
    }

    public void cargarNivelCarga(string nombreNivel)
    {
        if (!CargarController.nombrePartida.Equals("") && !CargarController.nombrePartida.Equals("vacio")) {
            DatosPartida.nombrePartida = CargarController.nombrePartida;
            SceneManager.LoadScene(nombreNivel);
        }
      
        
    }
}
