using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class DatosIniciales : MonoBehaviour
{
  
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
    
    // Update is called once per frame
    void Update()
    {
        nombrePartida1.text = nombrePartidaAux1;
        nombrePartida2.text = nombrePartidaAux2;
        nombrePartida3.text = nombrePartidaAux3;
       
    }

    private void ObtenerNombreLegibles(string nombre) {

        string[] listaNombre = nombre.Split('.');
        listaPartidanombre.Add(listaNombre[0]);

    }


    public void obtenerNombrePrimeraPartida() {

        nombrePartida1txt = nombrePartida1.text;
        nombrePartida1txt += ".txt";
        File.Delete(rutaGuardado + nombrePartida1txt);
        cargarDatos();
     
    }

    public void obtenerNombreSegundaPartida()
    {

        nombrePartida2txt = nombrePartida2.text;
        nombrePartida2txt += ".txt";
        File.Delete(rutaGuardado + nombrePartida2txt);
        cargarDatos();

    }

    public void obtenerNombreTerceraPartida()
    {

        nombrePartida3txt = nombrePartida3.text;
        nombrePartida3txt += ".txt";
        File.Delete(rutaGuardado + nombrePartida3txt);
        cargarDatos();
    }

    public void GuardarEnPosicion()
    {
        GuardarController guardado = new GuardarController();
        guardado.GuardarPartidaInGame();
    }

    public void guardarPartidaSlot1() {

        if (nombrePartida1.text.Equals("vacio")) {
            GameObject.FindGameObjectWithTag("guardar").GetComponent<GuardarController>().GuardarPartidaInGame();
            cargarDatos();
        }
    }

    public void guardarPartidaSlot2()
    {

        if (nombrePartida2.text.Equals("vacio"))
        {
            GameObject.FindGameObjectWithTag("guardar").GetComponent<GuardarController>().GuardarPartidaInGame();
            cargarDatos();
        }
    }

    public void guardarPartidaSlot3()
    {

        if (nombrePartida3.text.Equals("vacio"))
        {
            GameObject.FindGameObjectWithTag("guardar").GetComponent<GuardarController>().GuardarPartidaInGame();
            cargarDatos();
        }
    }
}
