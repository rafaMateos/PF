using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class RecuperarDatos : MonoBehaviour
{
   
    private string rutaGuardado = "C:/Users/" + Environment.UserName + "/Guardado/" + CargarController.nombrePartida + ".txt";
    private void Start()
    {
       
        if (File.Exists(rutaGuardado)) {
            ObtenerPosicionGuardada();
            ObtenerEstadoCofres();
            ObtenerEstadoSaludYDinero();
            ObtenerMana();
            obtenerMonedas();
            obtenerEstadoJarrones();
            ObtenerEstadoEnemigos();
            ObtenerEstadoPuertas();
        }
       
    }

    private void ObtenerPosicionGuardada() {
        string datosACargar = GuardarPartida.LeeArchivo(rutaGuardado);
        string[] listaDatosPosicion = datosACargar.Split('_');

        //Obtener posicion
        string[] posicionX;
        string[] posicionY;
        float posicionJugadorX = 0f;
        float posicionJugadorY = 0f;

        posicionX = listaDatosPosicion[0].Split(':');
        posicionY = listaDatosPosicion[1].Split(':');

        for (int i = 0; i < posicionX.Length; i++)
        {
            posicionJugadorX = float.Parse(posicionX[1]);
        }
        for (int i = 0; i < posicionY.Length; i++)
        {
            posicionJugadorY = float.Parse(posicionY[1]);
        }

        Vector3 pos = new Vector3(posicionJugadorX, posicionJugadorY, 0);
        GameObject.FindGameObjectWithTag("Player").transform.position = pos;
    }
    private void ObtenerEstadoCofres() {

        string datosACargar = GuardarPartida.LeeArchivo(rutaGuardado);
        string[] listaDatosPosicion = datosACargar.Split('_');

        string[] cofre1 = listaDatosPosicion[2].Split(':');
        string[] cofre2 = listaDatosPosicion[3].Split(':');
        string[] cofre3 = listaDatosPosicion[4].Split(':');
        string[] cofre4 = listaDatosPosicion[5].Split(':');
        string[] cofre5 = listaDatosPosicion[6].Split(':');
        string[] cofre6 = listaDatosPosicion[7].Split(':');
        string[] cofre7 = listaDatosPosicion[8].Split(':');
        string[] cofre8 = listaDatosPosicion[9].Split(':');


        string cofreEstado1 = cofre1[1];
        string cofreEstado2 = cofre2[1];
        string cofreEstado3 = cofre3[1];
        string cofreEstado4 = cofre4[1];
        string cofreEstado5 = cofre5[1];
        string cofreEstado6 = cofre6[1];
        string cofreEstado7 = cofre7[1];
        string cofreEstado8 = cofre8[1];


        if (cofreEstado1.Equals("True"))
        {
            GameObject.FindGameObjectWithTag("cofre1").GetComponent<ActivarAnimaciones>().estaAbiertoCarga = true;
            GameObject.FindGameObjectWithTag("cofre1").GetComponent<Animator>().Play("abrir");
            DatosPartida.cofre1 = true;

        }
        if (cofreEstado2.Equals("True"))
        {
            GameObject.FindGameObjectWithTag("cofre2").GetComponent<ActivarAnimaciones>().estaAbiertoCarga = true;
            GameObject.FindGameObjectWithTag("cofre2").GetComponent<Animator>().Play("abrir");
            DatosPartida.cofre2 = true;
        }
        if (cofreEstado3.Equals("True"))
        {
            GameObject.FindGameObjectWithTag("cofre3").GetComponent<ActivarAnimaciones>().estaAbiertoCarga = true;
            GameObject.FindGameObjectWithTag("cofre3").GetComponent<Animator>().Play("abrir");
            DatosPartida.cofre3 = true;
        }
        if (cofreEstado4.Equals("True"))
        {
            GameObject.FindGameObjectWithTag("cofre4").GetComponent<ActivarAnimaciones>().estaAbiertoCarga = true;
            GameObject.FindGameObjectWithTag("cofre4").GetComponent<Animator>().Play("abrir");
            DatosPartida.cofre4 = true;
        }
        if (cofreEstado5.Equals("True"))
        {
            GameObject.FindGameObjectWithTag("cofre5").GetComponent<ActivarAnimaciones>().estaAbiertoCarga = true;
            GameObject.FindGameObjectWithTag("cofre5").GetComponent<Animator>().Play("abrir");
            DatosPartida.cofre5 = true;
        }
        if (cofreEstado6.Equals("True"))
        {
            GameObject.FindGameObjectWithTag("cofre6").GetComponent<ActivarAnimaciones>().estaAbiertoCarga = true;
            GameObject.FindGameObjectWithTag("cofre6").GetComponent<Animator>().Play("abrir");
            DatosPartida.cofre6 = true;
        }
        if (cofreEstado7.Equals("True"))
        {
            GameObject.FindGameObjectWithTag("cofre7").GetComponent<ActivarAnimaciones>().estaAbiertoCarga = true;
            GameObject.FindGameObjectWithTag("cofre7").GetComponent<Animator>().Play("abrir");
            DatosPartida.cofre7 = true;
        }
        if (cofreEstado8.Equals("True"))
        {
            GameObject.FindGameObjectWithTag("cofre8").GetComponent<ActivarAnimaciones>().estaAbiertoCarga = true;
            GameObject.FindGameObjectWithTag("cofre8").GetComponent<Animator>().Play("abrir");
            DatosPartida.cofre8 = true;
        }
    }
    private void ObtenerEstadoSaludYDinero() {

        string datosACargar = GuardarPartida.LeeArchivo(rutaGuardado);
        string[] listaDatosDineroYSalud = datosACargar.Split('_');


        string[] dinero = listaDatosDineroYSalud[10].Split(':');
        string[] vidas = listaDatosDineroYSalud[11].Split(':');

        string dineroRecuperado = dinero[1];
        string vidasRecuperado = vidas[1];

        GameObject.FindGameObjectWithTag("dinero").GetComponent<Text>().text = dineroRecuperado;
        GameObject.FindGameObjectWithTag("vidas").GetComponent<Text>().text = vidasRecuperado;

        ScorePoint.puntos = int.Parse(dineroRecuperado);
        AtributosJugador.vidas = int.Parse(vidasRecuperado);

    }
    private void ObtenerMana() {

        string datosACargar = GuardarPartida.LeeArchivo(rutaGuardado);
        string[] listaMana = datosACargar.Split('_');


        string[] mana = listaMana[12].Split(':');

        string manaRecuperado = mana[1];

        AtributosJugador.mana = float.Parse(manaRecuperado);


    }
    private void obtenerMonedas() {

        string datosACargar = GuardarPartida.LeeArchivo(rutaGuardado);
        string[] listaMonedas = datosACargar.Split('_');

        string[] moneda1 = listaMonedas[13].Split(':');
        string[] moneda2 = listaMonedas[14].Split(':');
        string[] moneda3 = listaMonedas[15].Split(':');
        string[] moneda4 = listaMonedas[16].Split(':');
        string[] moneda5 = listaMonedas[17].Split(':');
        string[] moneda6 = listaMonedas[18].Split(':');
        string[] moneda7 = listaMonedas[19].Split(':');
        string[] moneda8 = listaMonedas[20].Split(':');
      


        string monedaEstado1 = moneda1[1];
        string monedaEstado2 = moneda2[1];
        string monedaEstado3 = moneda3[1];
        string monedaEstado4 = moneda4[1];
        string monedaEstado5 = moneda5[1];
        string monedaEstado6 = moneda6[1];
        string monedaEstado7 = moneda7[1];
        string monedaEstado8 = moneda8[1];


        if (monedaEstado1.Equals("True"))
        {
            Destroy(GameObject.FindGameObjectWithTag("moneda1"));
            DatosPartida.moneda1 = true;
        }
        if (monedaEstado2.Equals("True")) {

            Destroy(GameObject.FindGameObjectWithTag("moneda2"));
            DatosPartida.moneda2 = true;

        }
        if (monedaEstado3.Equals("True")) {

            Destroy(GameObject.FindGameObjectWithTag("moneda3"));
            DatosPartida.moneda3 = true;

        }

        if (monedaEstado4.Equals("True"))
        {

            Destroy(GameObject.FindGameObjectWithTag("moneda4"));
            DatosPartida.moneda4 = true;

        }
        if (monedaEstado5.Equals("True"))
        {

            Destroy(GameObject.FindGameObjectWithTag("moneda5"));
            DatosPartida.moneda5 = true;

        }
        if (monedaEstado6.Equals("True"))
        {

            Destroy(GameObject.FindGameObjectWithTag("moneda6"));
            DatosPartida.moneda6 = true;

        }
        if (monedaEstado7.Equals("True"))
        {

            Destroy(GameObject.FindGameObjectWithTag("moneda7"));
            DatosPartida.moneda7 = true;

        }
        if (monedaEstado8.Equals("True"))
        {

            Destroy(GameObject.FindGameObjectWithTag("moneda8"));
            DatosPartida.moneda8 = true;

        }

    }
    private void obtenerEstadoJarrones() {

        string datosACargar = GuardarPartida.LeeArchivo(rutaGuardado);
        string[] listaJarrones = datosACargar.Split('_');

        string[] jarron1 = listaJarrones[21].Split(':');
        string[] jarron2 = listaJarrones[22].Split(':');
        string[] jarron3 = listaJarrones[23].Split(':');
        string[] jarron4 = listaJarrones[24].Split(':');



        string jarronEstado1 = jarron1[1];
        string jarronEstado2 = jarron2[1];
        string jarronEstado3 = jarron3[1];
        string jarronEstado4 = jarron4[1];

        if (jarronEstado1.Equals("True")) {

            Destroy(GameObject.FindGameObjectWithTag("jarron1"));
            DatosPartida.jarron1 = true;
        }
        if (jarronEstado2.Equals("True")) {
            Destroy(GameObject.FindGameObjectWithTag("jarron2"));
            DatosPartida.jarron2 = true;
        }
        if (jarronEstado3.Equals("True")) {
            Destroy(GameObject.FindGameObjectWithTag("jarron3"));
            DatosPartida.jarron3 = true;
        }
        if (jarronEstado4.Equals("True")) {
            Destroy(GameObject.FindGameObjectWithTag("jarron4"));
            DatosPartida.jarron4 = true;
        }



    }
    private void ObtenerEstadoEnemigos() {

        string datosACargar = GuardarPartida.LeeArchivo(rutaGuardado);
        string[] listaEnemigos = datosACargar.Split('_');

        string[] enemigo1 = listaEnemigos[25].Split(':');
        string[] enemigo2 = listaEnemigos[26].Split(':');
        string[] enemigo3 = listaEnemigos[27].Split(':');
        string[] enemigo4 = listaEnemigos[28].Split(':');
        string[] enemigo5 = listaEnemigos[29].Split(':');
        string[] enemigo6 = listaEnemigos[30].Split(':');
        string[] enemigo7 = listaEnemigos[31].Split(':');
        string[] enemigo8 = listaEnemigos[32].Split(':');



        string enemigoEstado1 = enemigo1[1];
        string enemigoEstado2 = enemigo2[1];
        string enemigoEstado3 = enemigo3[1];
        string enemigoEstado4 = enemigo4[1];
        string enemigoEstado5 = enemigo5[1];
        string enemigoEstado6 = enemigo6[1];
        string enemigoEstado7 = enemigo7[1];
        string enemigoEstado8 = enemigo8[1];

        if (enemigoEstado1.Equals("True")) {
            Destroy(GameObject.FindGameObjectWithTag("Enemigo1"));
            DatosPartida.Enemigo1 = true;
        }
        if (enemigoEstado2.Equals("True")) {
            Destroy(GameObject.FindGameObjectWithTag("Enemigo2"));
            DatosPartida.Enemigo2 = true;

        }
        if (enemigoEstado3.Equals("True")) {
            Destroy(GameObject.FindGameObjectWithTag("Enemigo3"));
            DatosPartida.Enemigo3 = true;
        }
        if (enemigoEstado4.Equals("True")) {
            Destroy(GameObject.FindGameObjectWithTag("Enemigo4"));
            DatosPartida.Enemigo4 = true;
        }
        if (enemigoEstado5.Equals("True")) {
            Destroy(GameObject.FindGameObjectWithTag("Enemigo5"));
            DatosPartida.Enemigo5 = true;
        }
        if (enemigoEstado6.Equals("True"))
        {
            Destroy(GameObject.FindGameObjectWithTag("Enemigo6"));
            DatosPartida.Enemigo6 = true;
        }
        if (enemigoEstado7.Equals("True"))
        {
            Destroy(GameObject.FindGameObjectWithTag("Enemigo7"));
            DatosPartida.Enemigo7 = true;
        }
        if (enemigoEstado8.Equals("True"))
        {
            Destroy(GameObject.FindGameObjectWithTag("Enemigo8"));
            DatosPartida.Enemigo8 = true;
        }
    }
    private void ObtenerEstadoPuertas() {

        string datosACargar = GuardarPartida.LeeArchivo(rutaGuardado);
        string[] listaPuertas = datosACargar.Split('_');

        string[] puerta1 = listaPuertas[33].Split(':');
        string[] puerta2 = listaPuertas[34].Split(':');
        string[] puerta3 = listaPuertas[35].Split(':');

        string puertaEstado1 = puerta1[1];
        string puertaEstado2 = puerta2[1];
        string puertaEstado3 = puerta3[1];

        if (puertaEstado1.Equals("True")) {

            Destroy(GameObject.FindGameObjectWithTag("puerta1"));
            DatosPartida.puerta1 = true;
        }
        if (puertaEstado2.Equals("True"))
        {

            Destroy(GameObject.FindGameObjectWithTag("puerta2"));
            DatosPartida.puerta2 = true;
        }
        if (puertaEstado3.Equals("True"))
        {

            Destroy(GameObject.FindGameObjectWithTag("puerta3"));
            DatosPartida.puerta3 = true;
        }
    }
}
