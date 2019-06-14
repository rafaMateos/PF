using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class CargarController : MonoBehaviour
{
    //Varibles de Script
    private static string rutaGuardado = "C:/Users/" + Environment.UserInteractive + "/" + DatosPartida.nombrePartida;
    public static string nombrePartida = "";
    public Text texto;
    public Text texto1;
    public Text texto2;
    public static float posX;
    public static float posY;

    /// <summary>
    /// Metodo encargado de cargar la partida por defecto
    /// </summary>
    public void cargarPartidaInGame() {

        float posicionJugadorX = 0f;
        float posicionJugadorY = 0f;

        if (File.Exists(rutaGuardado)) {

            string datosACargar = GuardarPartida.LeeArchivo(rutaGuardado);

            string[] listaDatos;


            string[] posicionX;
            string[] posicionY;

            listaDatos = datosACargar.Split('_');

            posicionX = listaDatos[0].Split(':');
            posicionY = listaDatos[1].Split(':');

            for (int i = 0; i < posicionX.Length; i++)
            {
                posicionJugadorX = float.Parse(posicionX[1]);
                posX = posicionJugadorX;
            }
            for (int i = 0; i < posicionY.Length; i++)
            {
                posicionJugadorY = float.Parse(posicionY[1]);
                posY = posicionJugadorY;
            }
        }
        
    }

    public void cargarPorSeleccion() {

        nombrePartida = texto.text;

    }

    public void cargarPorSeleccion1()
    {

        nombrePartida = texto1.text;

    }

    public void cargarPorSeleccion2()
    {

        nombrePartida = texto2.text;

    }
}
