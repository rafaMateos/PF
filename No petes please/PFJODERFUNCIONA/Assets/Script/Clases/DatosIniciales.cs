using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class DatosIniciales : MonoBehaviour
{
  
    /// <summary>
    /// Variables de script
    /// </summary>
    string rutaGuardado = "C:/Users/" + Environment.UserName + "/Guardado/";
    public static List<string> lista = new List<string>();

    public Text nombrePartida1;
    public Text nombrePartida2;
    public Text nombrePartida3;

    public Text dineroPartida1;
    public Text vidasPartida1;

    public Text dineroPartida2;
    public Text vidasPartida2;

    public Text dineroPartida3;
    public Text vidasPartida3;

    private string nombrePartidaAux1 = "";
    private string nombrePartidaAux2 = "";
    private string nombrePartidaAux3 = "";

    private string nombrePartida1txt;
    private string nombrePartida2txt;
    private string nombrePartida3txt;


    public static FileInfo[] ficheros;
    public static int numeroPartidas = 0;

    public static List<string> listaPartidanombre = new List<string>();

   
    private void Start()
    {
        cargarDatos();
        
    }

    /// <summary>
    /// Metodo para obtener los datos iniciales de las partidas ya guardadas
    /// </summary>
    public void cargarDatos() {

        DirectoryInfo Dir = new DirectoryInfo(rutaGuardado);
        ficheros = Dir.GetFiles();

        lista.Clear();
        numeroPartidas = ficheros.Length;
        listaPartidanombre.Clear();
        for (int i = 0; i < ficheros.Length; i++)
        {
            lista.Add(ficheros[i].Name);
            ObtenerNombreLegibles(lista[i]);
        }


        switch (ficheros.Length)
        {

            case 1:
                nombrePartidaAux1 = listaPartidanombre[0];
                nombrePartidaAux2 = "vacio";
                nombrePartidaAux3 = "vacio";
                break;

            case 2:
                nombrePartidaAux1 = listaPartidanombre[0];
                nombrePartidaAux2 = listaPartidanombre[1];
                nombrePartidaAux3 = "vacio";
                break;

            case 3:
                nombrePartidaAux1 = listaPartidanombre[0];
                nombrePartidaAux2 = listaPartidanombre[1];
                nombrePartidaAux3 = listaPartidanombre[2];
                break;

            default:
                nombrePartidaAux1 = "vacio";
                nombrePartidaAux2 = "vacio";
                nombrePartidaAux3 = "vacio";
                break;
        }

        obtenerDineroYSalud();
    }

    /// <summary>
    /// Metodo para gestionar el dinero y salud de las partidas guardadas
    /// </summary>
    private void obtenerDineroYSalud() {

        switch (numeroPartidas) {

            case 1:
                obtenerDineroYSalud1Partida();
                break;
            case 2:
                ObtenerDineroYSalud2Partidas();
                break;
            case 3:
                ObtenerDineroYSalud3Partidas();
                break;

        }

    }

    /// <summary>
    /// Metodo para obtener dinero y salud de 1 partida
    /// </summary>
    private void obtenerDineroYSalud1Partida(){
        string rutaAux = rutaGuardado + lista[0];
        string datosACargar = GuardarPartida.LeeArchivo(rutaAux);
        string[] listaDatosDineroYSalud = datosACargar.Split('_');

        string[] dinero = listaDatosDineroYSalud[19].Split(':');
        string[] vidas = listaDatosDineroYSalud[20].Split(':');

        string dineroRecuperado = dinero[1];
        string vidasRecuperado = vidas[1];

        dineroPartida1.text = dineroRecuperado;
        vidasPartida1.text = vidasRecuperado;

    }

    /// <summary>
    /// Metodo para obtener dinero y salud de 2 partida
    /// </summary>
    private void ObtenerDineroYSalud2Partidas() {
        //Obtenemos el de la primera partida
        string rutaAux1 = rutaGuardado + lista[0];
        string datosACargar1 = GuardarPartida.LeeArchivo(rutaAux1);
        string[] listaDatosDineroYSalud1 = datosACargar1.Split('_');

        string[] dinero1 = listaDatosDineroYSalud1[19].Split(':');
        string[] vidas1 = listaDatosDineroYSalud1[20].Split(':');

        string dineroRecuperado1 = dinero1[1];
        string vidasRecuperado1 = vidas1[1];

        dineroPartida1.text = dineroRecuperado1;
        vidasPartida1.text = vidasRecuperado1;

        //Obtnemos el de la segunda partida
        string rutaAux2 = rutaGuardado + lista[1];
        string datosACargar2 = GuardarPartida.LeeArchivo(rutaAux2);
        string[] listaDatosDineroYSalud2 = datosACargar2.Split('_');

        string[] dinero2 = listaDatosDineroYSalud2[19].Split(':');
        string[] vidas2 = listaDatosDineroYSalud2[20].Split(':');

        string dineroRecuperado2 = dinero2[1];
        string vidasRecuperado2 = vidas2[1];

        dineroPartida2.text = dineroRecuperado2;
        vidasPartida2.text = vidasRecuperado2;
    }


    /// <summary>
    /// Metodo para obtener dinero y salud de 3 partida
    /// </summary>
    private void ObtenerDineroYSalud3Partidas() {
        //Obtenemos el de la primera partida
        string rutaAux1 = rutaGuardado + lista[0];
        string datosACargar1 = GuardarPartida.LeeArchivo(rutaAux1);
        string[] listaDatosDineroYSalud1 = datosACargar1.Split('_');

        string[] dinero1 = listaDatosDineroYSalud1[19].Split(':');
        string[] vidas1 = listaDatosDineroYSalud1[20].Split(':');

        string dineroRecuperado1 = dinero1[1];
        string vidasRecuperado1 = vidas1[1];

        dineroPartida1.text = dineroRecuperado1;
        vidasPartida1.text = vidasRecuperado1;

        //Obtnemos el de la segunda partida
        string rutaAux2 = rutaGuardado + lista[1];
        string datosACargar2 = GuardarPartida.LeeArchivo(rutaAux2);
        string[] listaDatosDineroYSalud2 = datosACargar2.Split('_');

        string[] dinero2 = listaDatosDineroYSalud2[19].Split(':');
        string[] vidas2 = listaDatosDineroYSalud2[20].Split(':');

        string dineroRecuperado2 = dinero2[1];
        string vidasRecuperado2 = vidas2[1];

        dineroPartida2.text = dineroRecuperado2;
        vidasPartida2.text = vidasRecuperado2;


        //Obtnemos el de la tercera partida
        string rutaAux3 = rutaGuardado + lista[2];
        string datosACargar3 = GuardarPartida.LeeArchivo(rutaAux3);
        string[] listaDatosDineroYSalud3 = datosACargar3.Split('_');

        string[] dinero3 = listaDatosDineroYSalud3[19].Split(':');
        string[] vidas3 = listaDatosDineroYSalud3[20].Split(':');

        string dineroRecuperado3 = dinero3[1];
        string vidasRecuperado3 = vidas3[1];

        dineroPartida3.text = dineroRecuperado3;
        vidasPartida3.text = vidasRecuperado3;


    }
    
  /// <summary>
  /// Funcion uodate encargada de los mostrar actualizados los nombres de las partidas
  /// </summary>
    void Update()
    {
        nombrePartida1.text = nombrePartidaAux1;
        nombrePartida2.text = nombrePartidaAux2;
        nombrePartida3.text = nombrePartidaAux3;
       
    }

    /// <summary>
    /// Metodo para obtener nombre de partidas legibles
    /// </summary>
    /// <param name="nombre"></param>
    private void ObtenerNombreLegibles(string nombre) {

        string[] listaNombre = nombre.Split('.');
        listaPartidanombre.Add(listaNombre[0]);

    }

    /// <summary>
    /// Funcion para obtener el nombre de la 1 partida
    /// </summary>
    public void obtenerNombrePrimeraPartida() {

        nombrePartida1txt = nombrePartida1.text;
        nombrePartida1txt += ".txt";
        File.Delete(rutaGuardado + nombrePartida1txt);
        cargarDatos();
     
    }
    /// <summary>
    /// Funcion para obtener el nombre de la 2 partida
    /// </summary>
    public void obtenerNombreSegundaPartida()
    {

        nombrePartida2txt = nombrePartida2.text;
        nombrePartida2txt += ".txt";
        File.Delete(rutaGuardado + nombrePartida2txt);
        cargarDatos();

    }

    /// <summary>
    /// Funcion para obtener el nombre de la 1 partida
    /// </summary>
    public void obtenerNombreTerceraPartida()
    {

        nombrePartida3txt = nombrePartida3.text;
        nombrePartida3txt += ".txt";
        File.Delete(rutaGuardado + nombrePartida3txt);
        cargarDatos();
    }

    /// <summary>
    /// Metodo para guardar y recargar en el momento deseado 
    /// </summary>
    public void GuardarEnPosicion()
    {
        GuardarController guardado = new GuardarController();
        guardado.GuardarPartidaInGame();
    }

    /// <summary>
    /// Metodo encargado de la gestion guardado partida tras sobreescribir
    /// </summary>
    public void guardarPartidaSlot1() {

        if (nombrePartida1.text.Equals("vacio")) {
            GameObject.FindGameObjectWithTag("guardar").GetComponent<GuardarController>().GuardarPartidaInGame();
            cargarDatos();
        }
    }

    /// <summary>
    /// Metodo encargado de la gestion guardado partida tras sobreescribir
    /// </summary>
    public void guardarPartidaSlot2()
    {

        if (nombrePartida2.text.Equals("vacio"))
        {
            GameObject.FindGameObjectWithTag("guardar").GetComponent<GuardarController>().GuardarPartidaInGame();
            cargarDatos();
        }
    }

    /// <summary>
    /// Metodo encargado de la gestion guardado partida tras sobreescribir
    /// </summary>
    public void guardarPartidaSlot3()
    {

        if (nombrePartida3.text.Equals("vacio"))
        {
            GameObject.FindGameObjectWithTag("guardar").GetComponent<GuardarController>().GuardarPartidaInGame();
            cargarDatos();
        }
    }
}
