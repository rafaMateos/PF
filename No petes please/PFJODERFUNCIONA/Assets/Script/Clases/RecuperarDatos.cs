using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class RecuperarDatos : MonoBehaviour
{
   
    private string rutaGuardado = "C:/Users/" + Environment.UserName + "/Guardado/" + CargarController.nombrePartida + ".txt";
    public GameObject pocion;
    public GameObject mana;
    public GameObject vida;
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
            ObtenerEstadoArmadura();
            ObtenerEstadoEspada();
            ObtenerObjetosInventario();
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
        string[] cofre9 = listaDatosPosicion[10].Split(':');
        string[] cofre10 = listaDatosPosicion[11].Split(':');
        string[] cofre11 = listaDatosPosicion[12].Split(':');
        string[] cofre12 = listaDatosPosicion[13].Split(':');
        string[] cofre13 = listaDatosPosicion[14].Split(':');
        string[] cofre14 = listaDatosPosicion[15].Split(':');
        string[] cofre15 = listaDatosPosicion[16].Split(':');
        string[] cofre16 = listaDatosPosicion[17].Split(':');
        string[] cofre17 = listaDatosPosicion[18].Split(':');


        string cofreEstado1 = cofre1[1];
        string cofreEstado2 = cofre2[1];
        string cofreEstado3 = cofre3[1];
        string cofreEstado4 = cofre4[1];
        string cofreEstado5 = cofre5[1];
        string cofreEstado6 = cofre6[1];
        string cofreEstado7 = cofre7[1];
        string cofreEstado8 = cofre8[1];
        string cofreEstado9 = cofre9[1];
        string cofreEstado10 = cofre10[1];
        string cofreEstado11 = cofre11[1];
        string cofreEstado12 = cofre12[1];
        string cofreEstado13 = cofre13[1];
        string cofreEstado14 = cofre14[1];
        string cofreEstado15 = cofre15[1];
        string cofreEstado16 = cofre16[1];
        string cofreEstado17 = cofre17[1];


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
        if (cofreEstado9.Equals("True"))
        {
            GameObject.FindGameObjectWithTag("cofre9").GetComponent<ActivarAnimaciones>().estaAbiertoCarga = true;
            GameObject.FindGameObjectWithTag("cofre9").GetComponent<Animator>().Play("abrir");
            DatosPartida.cofre9 = true;
        }
        if (cofreEstado10.Equals("True"))
        {
            GameObject.FindGameObjectWithTag("cofre10").GetComponent<ActivarAnimaciones>().estaAbiertoCarga = true;
            GameObject.FindGameObjectWithTag("cofre10").GetComponent<Animator>().Play("abrir");
            DatosPartida.cofre10 = true;
        }
        if (cofreEstado11.Equals("True"))
        {
            GameObject.FindGameObjectWithTag("cofre11").GetComponent<ActivarAnimaciones>().estaAbiertoCarga = true;
            GameObject.FindGameObjectWithTag("cofre11").GetComponent<Animator>().Play("abrir");
            DatosPartida.cofre11 = true;
        }
        if (cofreEstado12.Equals("True"))
        {
            GameObject.FindGameObjectWithTag("cofre12").GetComponent<ActivarAnimaciones>().estaAbiertoCarga = true;
            GameObject.FindGameObjectWithTag("cofre12").GetComponent<Animator>().Play("abrir");
            DatosPartida.cofre12 = true;
        }
        if (cofreEstado13.Equals("True"))
        {
            GameObject.FindGameObjectWithTag("cofre13").GetComponent<ActivarAnimaciones>().estaAbiertoCarga = true;
            GameObject.FindGameObjectWithTag("cofre13").GetComponent<Animator>().Play("abrir");
            DatosPartida.cofre13 = true;
        }
        if (cofreEstado14.Equals("True"))
        {
            GameObject.FindGameObjectWithTag("cofre14").GetComponent<ActivarAnimaciones>().estaAbiertoCarga = true;
            GameObject.FindGameObjectWithTag("cofre14").GetComponent<Animator>().Play("abrir");
            DatosPartida.cofre14 = true;
        }
        if (cofreEstado15.Equals("True"))
        {
            GameObject.FindGameObjectWithTag("cofre15").GetComponent<ActivarAnimaciones>().estaAbiertoCarga = true;
            GameObject.FindGameObjectWithTag("cofre15").GetComponent<Animator>().Play("abrir");
            DatosPartida.cofre15 = true;
        }
        if (cofreEstado16.Equals("True"))
        {
            GameObject.FindGameObjectWithTag("cofre16").GetComponent<ActivarAnimaciones>().estaAbiertoCarga = true;
            GameObject.FindGameObjectWithTag("cofre16").GetComponent<Animator>().Play("abrir");
            DatosPartida.cofre16 = true;
        }
        if (cofreEstado17.Equals("True"))
        {
            GameObject.FindGameObjectWithTag("cofre17").GetComponent<ActivarAnimaciones>().estaAbiertoCarga = true;
            GameObject.FindGameObjectWithTag("cofre17").GetComponent<Animator>().Play("abrir");
            DatosPartida.cofre17 = true;
        }
    }
    private void ObtenerEstadoSaludYDinero() {

        string datosACargar = GuardarPartida.LeeArchivo(rutaGuardado);
        string[] listaDatosDineroYSalud = datosACargar.Split('_');


        string[] dinero = listaDatosDineroYSalud[19].Split(':');
        string[] vidas = listaDatosDineroYSalud[20].Split(':');

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


        string[] mana = listaMana[21].Split(':');

        string manaRecuperado = mana[1];

        AtributosJugador.mana = float.Parse(manaRecuperado);


    }
    private void obtenerMonedas() {

        string datosACargar = GuardarPartida.LeeArchivo(rutaGuardado);
        string[] listaMonedas = datosACargar.Split('_');

        string[] moneda1 = listaMonedas[22].Split(':');
        string[] moneda2 = listaMonedas[23].Split(':');
        string[] moneda3 = listaMonedas[24].Split(':');
        string[] moneda4 = listaMonedas[25].Split(':');
        string[] moneda5 = listaMonedas[26].Split(':');
        string[] moneda6 = listaMonedas[27].Split(':');
        string[] moneda7 = listaMonedas[28].Split(':');
        string[] moneda8 = listaMonedas[29].Split(':');
        string[] moneda9 = listaMonedas[30].Split(':');
        string[] moneda10 = listaMonedas[31].Split(':');
        string[] moneda11 = listaMonedas[32].Split(':');
        string[] moneda12 = listaMonedas[33].Split(':');
        string[] moneda13 = listaMonedas[34].Split(':');
        string[] moneda14 = listaMonedas[35].Split(':');
        string[] moneda15 = listaMonedas[36].Split(':');
        string[] moneda16 = listaMonedas[36].Split(':');
        string[] moneda17 = listaMonedas[38].Split(':');
        string[] moneda18 = listaMonedas[39].Split(':');
        string[] moneda19 = listaMonedas[40].Split(':');
        string[] moneda20 = listaMonedas[41].Split(':');
        string[] moneda21 = listaMonedas[42].Split(':');
        string[] moneda22 = listaMonedas[43].Split(':');
        string[] moneda23 = listaMonedas[44].Split(':');
        string[] moneda24 = listaMonedas[45].Split(':');
        string[] moneda25 = listaMonedas[46].Split(':');
        string[] moneda26 = listaMonedas[47].Split(':');
        string[] moneda27= listaMonedas[48].Split(':');
        string[] moneda28 = listaMonedas[49].Split(':');
        string[] moneda29 = listaMonedas[50].Split(':');
        string[] moneda30 = listaMonedas[51].Split(':');
        string[] moneda31 = listaMonedas[52].Split(':');
        string[] moneda32 = listaMonedas[53].Split(':');
        string[] moneda33 = listaMonedas[54].Split(':');
        string[] moneda34 = listaMonedas[55].Split(':');
      


        string monedaEstado1 = moneda1[1];
        string monedaEstado2 = moneda2[1];
        string monedaEstado3 = moneda3[1];
        string monedaEstado4 = moneda4[1];
        string monedaEstado5 = moneda5[1];
        string monedaEstado6 = moneda6[1];
        string monedaEstado7 = moneda7[1];
        string monedaEstado8 = moneda8[1];
        string monedaEstado9 = moneda9[1];
        string monedaEstado10 = moneda10[1];
        string monedaEstado11 = moneda11[1];
        string monedaEstado12 = moneda12[1];
        string monedaEstado13 = moneda13[1];
        string monedaEstado14 = moneda14[1];
        string monedaEstado15 = moneda15[1];
        string monedaEstado16 = moneda16[1];
        string monedaEstado17 = moneda17[1];
        string monedaEstado18 = moneda18[1];
        string monedaEstado19 = moneda19[1];
        string monedaEstado20 = moneda20[1];
        string monedaEstado21 = moneda21[1];
        string monedaEstado22 = moneda22[1];
        string monedaEstado23 = moneda23[1];
        string monedaEstado24 = moneda24[1];
        string monedaEstado25 = moneda25[1];
        string monedaEstado26 = moneda26[1];
        string monedaEstado27 = moneda27[1];
        string monedaEstado28 = moneda28[1];
        string monedaEstado29 = moneda29[1];
        string monedaEstado30 = moneda30[1];
        string monedaEstado31 = moneda31[1];
        string monedaEstado32 = moneda32[1];
        string monedaEstado33 = moneda33[1];
        string monedaEstado34 = moneda34[1];


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
        if (monedaEstado9.Equals("True"))
        {

            Destroy(GameObject.FindGameObjectWithTag("moneda9"));
            DatosPartida.moneda9 = true;

        }
        if (monedaEstado10.Equals("True"))
        {

            Destroy(GameObject.FindGameObjectWithTag("moneda10"));
            DatosPartida.moneda10 = true;

        }
        if (monedaEstado11.Equals("True"))
        {

            Destroy(GameObject.FindGameObjectWithTag("moneda11"));
            DatosPartida.moneda11 = true;

        }
        if (monedaEstado12.Equals("True"))
        {

            Destroy(GameObject.FindGameObjectWithTag("moneda12"));
            DatosPartida.moneda12 = true;

        }
        if (monedaEstado13.Equals("True"))
        {

            Destroy(GameObject.FindGameObjectWithTag("moneda13"));
            DatosPartida.moneda13 = true;

        }
        if (monedaEstado14.Equals("True"))
        {

            Destroy(GameObject.FindGameObjectWithTag("moneda14"));
            DatosPartida.moneda14 = true;

        }
        if (monedaEstado15.Equals("True"))
        {

            Destroy(GameObject.FindGameObjectWithTag("moneda15"));
            DatosPartida.moneda15 = true;

        }
        if (monedaEstado16.Equals("True"))
        {

            Destroy(GameObject.FindGameObjectWithTag("moneda16"));
            DatosPartida.moneda16 = true;

        }
        if (monedaEstado17.Equals("True"))
        {

            Destroy(GameObject.FindGameObjectWithTag("moneda17"));
            DatosPartida.moneda17 = true;

        }
        if (monedaEstado18.Equals("True"))
        {

            Destroy(GameObject.FindGameObjectWithTag("moneda18"));
            DatosPartida.moneda18 = true;

        }
        if (monedaEstado19.Equals("True"))
        {

            Destroy(GameObject.FindGameObjectWithTag("moneda19"));
            DatosPartida.moneda19 = true;

        }
        if (monedaEstado20.Equals("True"))
        {

            Destroy(GameObject.FindGameObjectWithTag("moneda20"));
            DatosPartida.moneda20 = true;

        }
        if (monedaEstado21.Equals("True"))
        {

            Destroy(GameObject.FindGameObjectWithTag("moneda21"));
            DatosPartida.moneda21 = true;

        }
        if (monedaEstado22.Equals("True"))
        {

            Destroy(GameObject.FindGameObjectWithTag("moneda22"));
            DatosPartida.moneda22 = true;

        }
        if (monedaEstado23.Equals("True"))
        {

            Destroy(GameObject.FindGameObjectWithTag("moneda23"));
            DatosPartida.moneda23 = true;

        }
        if (monedaEstado24.Equals("True"))
        {

            Destroy(GameObject.FindGameObjectWithTag("moneda24"));
            DatosPartida.moneda24 = true;

        }
        if (monedaEstado25.Equals("True"))
        {

            Destroy(GameObject.FindGameObjectWithTag("moneda25"));
            DatosPartida.moneda25 = true;

        }
        if (monedaEstado26.Equals("True"))
        {

            Destroy(GameObject.FindGameObjectWithTag("moneda26"));
            DatosPartida.moneda26 = true;

        }
        if (monedaEstado27.Equals("True"))
        {

            Destroy(GameObject.FindGameObjectWithTag("moneda27"));
            DatosPartida.moneda27 = true;

        }
        if (monedaEstado28.Equals("True"))
        {

            Destroy(GameObject.FindGameObjectWithTag("moneda28"));
            DatosPartida.moneda28 = true;

        }
        if (monedaEstado29.Equals("True"))
        {

            Destroy(GameObject.FindGameObjectWithTag("moneda29"));
            DatosPartida.moneda29 = true;

        }
        if (monedaEstado30.Equals("True"))
        {

            Destroy(GameObject.FindGameObjectWithTag("moneda30"));
            DatosPartida.moneda30 = true;

        }
        if (monedaEstado31.Equals("True"))
        {

            Destroy(GameObject.FindGameObjectWithTag("moneda31"));
            DatosPartida.moneda31 = true;

        }
        if (monedaEstado32.Equals("True"))
        {

            Destroy(GameObject.FindGameObjectWithTag("moneda32"));
            DatosPartida.moneda32 = true;

        }
        if (monedaEstado33.Equals("True"))
        {

            Destroy(GameObject.FindGameObjectWithTag("moneda33"));
            DatosPartida.moneda33 = true;

        }
        if (monedaEstado34.Equals("True"))
        {

            Destroy(GameObject.FindGameObjectWithTag("moneda34"));
            DatosPartida.moneda34 = true;

        }

    }
    private void obtenerEstadoJarrones() {

        string datosACargar = GuardarPartida.LeeArchivo(rutaGuardado);
        string[] listaJarrones = datosACargar.Split('_');

        string[] jarron1 = listaJarrones[56].Split(':');
        string[] jarron2 = listaJarrones[57].Split(':');
        string[] jarron3 = listaJarrones[58].Split(':');
        string[] jarron4 = listaJarrones[59].Split(':');



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

        string[] enemigo1 = listaEnemigos[60].Split(':');
        string[] enemigo2 = listaEnemigos[61].Split(':');
        string[] enemigo3 = listaEnemigos[62].Split(':');
        string[] enemigo4 = listaEnemigos[63].Split(':');
        string[] enemigo5 = listaEnemigos[63].Split(':');
        string[] enemigo6 = listaEnemigos[65].Split(':');
        string[] enemigo7 = listaEnemigos[66].Split(':');
        string[] enemigo8 = listaEnemigos[67].Split(':');
        string[] enemigo9 = listaEnemigos[68].Split(':');
        string[] enemigo10 = listaEnemigos[69].Split(':');
        string[] enemigo11 = listaEnemigos[70].Split(':');
        string[] enemigo12 = listaEnemigos[71].Split(':');
        string[] enemigo13 = listaEnemigos[72].Split(':');
        string[] enemigo14 = listaEnemigos[73].Split(':');
        string[] enemigo15 = listaEnemigos[74].Split(':');
        string[] enemigo16 = listaEnemigos[75].Split(':');
        string[] enemigo17 = listaEnemigos[76].Split(':');
        string[] enemigo18 = listaEnemigos[77].Split(':');
        string[] enemigo19 = listaEnemigos[78].Split(':');
        string[] enemigo20 = listaEnemigos[79].Split(':');
        string[] enemigo21 = listaEnemigos[80].Split(':');
        string[] enemigo22 = listaEnemigos[81].Split(':');
        string[] enemigo23 = listaEnemigos[82].Split(':');
        string[] enemigo24 = listaEnemigos[83].Split(':');
        string[] enemigo25 = listaEnemigos[84].Split(':');
        string[] enemigo26 = listaEnemigos[85].Split(':');
        string[] enemigo27 = listaEnemigos[86].Split(':');
        string[] enemigo28 = listaEnemigos[87].Split(':');
        string[] enemigo29 = listaEnemigos[88].Split(':');
        string[] enemigo30 = listaEnemigos[89].Split(':');
        string[] enemigo31 = listaEnemigos[90].Split(':');
        string[] enemigo32 = listaEnemigos[91].Split(':');
        string[] enemigo33 = listaEnemigos[92].Split(':');
        string[] enemigo34 = listaEnemigos[93].Split(':');
        string[] enemigo35 = listaEnemigos[94].Split(':');
        string[] enemigo36 = listaEnemigos[95].Split(':');
        string[] enemigo37 = listaEnemigos[96].Split(':');
        string[] enemigo38 = listaEnemigos[97].Split(':');
        string[] enemigo39 = listaEnemigos[98].Split(':');
        string[] enemigo40 = listaEnemigos[99].Split(':');
        string[] enemigo41 = listaEnemigos[100].Split(':');
        string[] enemigo42 = listaEnemigos[101].Split(':');
        string[] enemigo43 = listaEnemigos[102].Split(':');
        string[] enemigo44 = listaEnemigos[103].Split(':');
        string[] enemigo45 = listaEnemigos[104].Split(':');
        string[] enemigo46 = listaEnemigos[105].Split(':');
        string[] enemigo47 = listaEnemigos[106].Split(':');
        string[] enemigo48 = listaEnemigos[107].Split(':');
        string[] enemigo49 = listaEnemigos[108].Split(':');
        string[] enemigo50 = listaEnemigos[109].Split(':');
        string[] enemigo51 = listaEnemigos[110].Split(':');
        string[] enemigo52 = listaEnemigos[111].Split(':');



        string enemigoEstado1 = enemigo1[1];
        string enemigoEstado2 = enemigo2[1];
        string enemigoEstado3 = enemigo3[1];
        string enemigoEstado4 = enemigo4[1];
        string enemigoEstado5 = enemigo5[1];
        string enemigoEstado6 = enemigo6[1];
        string enemigoEstado7 = enemigo7[1];
        string enemigoEstado8 = enemigo8[1];
        string enemigoEstado9 = enemigo9[1];
        string enemigoEstado10 = enemigo10[1];
        string enemigoEstado11 = enemigo11[1];
        string enemigoEstado12 = enemigo12[1];
        string enemigoEstado13 = enemigo13[1];
        string enemigoEstado14 = enemigo14[1];
        string enemigoEstado15 = enemigo15[1];
        string enemigoEstado16 = enemigo16[1];
        string enemigoEstado17 = enemigo17[1];
        string enemigoEstado18 = enemigo18[1];
        string enemigoEstado19 = enemigo19[1];
        string enemigoEstado20 = enemigo20[1];
        string enemigoEstado21 = enemigo21[1];
        string enemigoEstado22 = enemigo22[1];
        string enemigoEstado23 = enemigo23[1];
        string enemigoEstado24 = enemigo24[1];
        string enemigoEstado25 = enemigo25[1];
        string enemigoEstado26= enemigo26[1];
        string enemigoEstado27= enemigo27[1];
        string enemigoEstado28 = enemigo28[1];
        string enemigoEstado29 = enemigo29[1];
        string enemigoEstado30 = enemigo30[1];
        string enemigoEstado31 = enemigo31[1];
        string enemigoEstado32 = enemigo32[1];
        string enemigoEstado33 = enemigo33[1];
        string enemigoEstado34 = enemigo34[1];
        string enemigoEstado35 = enemigo35[1];
        string enemigoEstado36 = enemigo36[1];
        string enemigoEstado37= enemigo37[1];
        string enemigoEstado38 = enemigo38[1];
        string enemigoEstado39 = enemigo39[1];
        string enemigoEstado40 = enemigo40[1];
        string enemigoEstado41 = enemigo41[1];
        string enemigoEstado42 = enemigo42[1];
        string enemigoEstado43 = enemigo43[1];
        string enemigoEstado44 = enemigo44[1];
        string enemigoEstado45 = enemigo45[1];
        string enemigoEstado46 = enemigo46[1];
        string enemigoEstado47 = enemigo47[1];
        string enemigoEstado48 = enemigo48[1];
        string enemigoEstado49 = enemigo49[1];
        string enemigoEstado50 = enemigo50[1];
        string enemigoEstado51 = enemigo51[1];
        string enemigoEstado52 = enemigo52[1];

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
        if (enemigoEstado9.Equals("True"))
        {
            Destroy(GameObject.FindGameObjectWithTag("Enemigo9"));
            DatosPartida.Enemigo9 = true;
        }
        if (enemigoEstado10.Equals("True"))
        {
            Destroy(GameObject.FindGameObjectWithTag("Enemigo10"));
            DatosPartida.Enemigo10= true;
        }
        if (enemigoEstado11.Equals("True"))
        {
            Destroy(GameObject.FindGameObjectWithTag("Enemigo11"));
            DatosPartida.Enemigo11 = true;
        }
        if (enemigoEstado12.Equals("True"))
        {
            Destroy(GameObject.FindGameObjectWithTag("Enemigo12"));
            DatosPartida.Enemigo12 = true;
        }
        if (enemigoEstado13.Equals("True"))
        {
            Destroy(GameObject.FindGameObjectWithTag("Enemigo13"));
            DatosPartida.Enemigo13 = true;
        }
        if (enemigoEstado14.Equals("True"))
        {
            Destroy(GameObject.FindGameObjectWithTag("Enemigo14"));
            DatosPartida.Enemigo14 = true;
        }
        if (enemigoEstado15.Equals("True"))
        {
            Destroy(GameObject.FindGameObjectWithTag("Enemigo15"));
            DatosPartida.Enemigo15 = true;
        }
        if (enemigoEstado16.Equals("True"))
        {
            Destroy(GameObject.FindGameObjectWithTag("Enemigo16"));
            DatosPartida.Enemigo16 = true;
        }
        if (enemigoEstado17.Equals("True"))
        {
            Destroy(GameObject.FindGameObjectWithTag("Enemigo17"));
            DatosPartida.Enemigo17 = true;
        }
        if (enemigoEstado18.Equals("True"))
        {
            Destroy(GameObject.FindGameObjectWithTag("Enemigo18"));
            DatosPartida.Enemigo18 = true;
        }
        if (enemigoEstado19.Equals("True"))
        {
            Destroy(GameObject.FindGameObjectWithTag("Enemigo19"));
            DatosPartida.Enemigo19 = true;
        }
        if (enemigoEstado20.Equals("True"))
        {
            Destroy(GameObject.FindGameObjectWithTag("Enemigo20"));
            DatosPartida.Enemigo20 = true;
        }
        if (enemigoEstado21.Equals("True"))
        {
            Destroy(GameObject.FindGameObjectWithTag("Enemigo21"));
            DatosPartida.Enemigo21 = true;
        }
        if (enemigoEstado22.Equals("True"))
        {
            Destroy(GameObject.FindGameObjectWithTag("Enemigo22"));
            DatosPartida.Enemigo22 = true;
        }
        if (enemigoEstado23.Equals("True"))
        {
            Destroy(GameObject.FindGameObjectWithTag("Enemigo23"));
            DatosPartida.Enemigo23 = true;
        }
        if (enemigoEstado24.Equals("True"))
        {
            Destroy(GameObject.FindGameObjectWithTag("Enemigo24"));
            DatosPartida.Enemigo24 = true;
        }
        if (enemigoEstado25.Equals("True"))
        {
            Destroy(GameObject.FindGameObjectWithTag("Enemigo25"));
            DatosPartida.Enemigo25 = true;
        }
        if (enemigoEstado26.Equals("True"))
        {
            Destroy(GameObject.FindGameObjectWithTag("Enemigo26"));
            DatosPartida.Enemigo26 = true;
        }
        if (enemigoEstado27.Equals("True"))
        {
            Destroy(GameObject.FindGameObjectWithTag("Enemigo27"));
            DatosPartida.Enemigo27 = true;
        }
        if (enemigoEstado28.Equals("True"))
        {
            Destroy(GameObject.FindGameObjectWithTag("Enemigo28"));
            DatosPartida.Enemigo28 = true;
        }
        if (enemigoEstado29.Equals("True"))
        {
            Destroy(GameObject.FindGameObjectWithTag("Enemigo29"));
            DatosPartida.Enemigo29 = true;
        }
        if (enemigoEstado30.Equals("True"))
        {
            Destroy(GameObject.FindGameObjectWithTag("Enemigo30"));
            DatosPartida.Enemigo30 = true;
        }
        if (enemigoEstado31.Equals("True"))
        {
            Destroy(GameObject.FindGameObjectWithTag("Enemigo31"));
            DatosPartida.Enemigo31 = true;
        }
        if (enemigoEstado32.Equals("True"))
        {
            Destroy(GameObject.FindGameObjectWithTag("Enemigo32"));
            DatosPartida.Enemigo32 = true;
        }
        if (enemigoEstado33.Equals("True"))
        {
            Destroy(GameObject.FindGameObjectWithTag("Enemigo33"));
            DatosPartida.Enemigo33 = true;
        }
        if (enemigoEstado34.Equals("True"))
        {
            Destroy(GameObject.FindGameObjectWithTag("Enemigo34"));
            DatosPartida.Enemigo34 = true;
        }
        if (enemigoEstado35.Equals("True"))
        {
            Destroy(GameObject.FindGameObjectWithTag("Enemigo35"));
            DatosPartida.Enemigo35 = true;
        }
        if (enemigoEstado36.Equals("True"))
        {
            Destroy(GameObject.FindGameObjectWithTag("Enemigo36"));
            DatosPartida.Enemigo36 = true;
        }
        if (enemigoEstado37.Equals("True"))
        {
            Destroy(GameObject.FindGameObjectWithTag("Enemigo37"));
            DatosPartida.Enemigo37 = true;
        }
        if (enemigoEstado38.Equals("True"))
        {
            Destroy(GameObject.FindGameObjectWithTag("Enemigo38"));
            DatosPartida.Enemigo38 = true;
        }
        if (enemigoEstado39.Equals("True"))
        {
            Destroy(GameObject.FindGameObjectWithTag("Enemigo39"));
            DatosPartida.Enemigo39 = true;
        }
        if (enemigoEstado40.Equals("True"))
        {
            Destroy(GameObject.FindGameObjectWithTag("Enemigo40"));
            DatosPartida.Enemigo40 = true;
        }
        if (enemigoEstado41.Equals("True"))
        {
            Destroy(GameObject.FindGameObjectWithTag("Enemigo41"));
            DatosPartida.Enemigo41 = true;
        }
        if (enemigoEstado42.Equals("True"))
        {
            Destroy(GameObject.FindGameObjectWithTag("Enemigo42"));
            DatosPartida.Enemigo42 = true;
        }
        if (enemigoEstado43.Equals("True"))
        {
            Destroy(GameObject.FindGameObjectWithTag("Enemigo43"));
            DatosPartida.Enemigo43 = true;
        }
        if (enemigoEstado44.Equals("True"))
        {
            Destroy(GameObject.FindGameObjectWithTag("Enemigo44"));
            DatosPartida.Enemigo44 = true;
        }
        if (enemigoEstado45.Equals("True"))
        {
            Destroy(GameObject.FindGameObjectWithTag("Enemigo45"));
            DatosPartida.Enemigo45 = true;
        }
        if (enemigoEstado46.Equals("True"))
        {
            Destroy(GameObject.FindGameObjectWithTag("Enemigo46"));
            DatosPartida.Enemigo46 = true;
        }
        if (enemigoEstado47.Equals("True"))
        {
            Destroy(GameObject.FindGameObjectWithTag("Enemigo47"));
            DatosPartida.Enemigo47 = true;
        }
        if (enemigoEstado48.Equals("True"))
        {
            Destroy(GameObject.FindGameObjectWithTag("Enemigo48"));
            DatosPartida.Enemigo48 = true;
        }
        if (enemigoEstado49.Equals("True"))
        {
            Destroy(GameObject.FindGameObjectWithTag("Enemigo49"));
            DatosPartida.Enemigo49 = true;
        }
        if (enemigoEstado50.Equals("True"))
        {
            Destroy(GameObject.FindGameObjectWithTag("Enemigo50"));
            DatosPartida.Enemigo50 = true;
        }
        if (enemigoEstado51.Equals("True"))
        {
            Destroy(GameObject.FindGameObjectWithTag("Enemigo51"));
            DatosPartida.Enemigo51 = true;
        }
        if (enemigoEstado52.Equals("True"))
        {
            Destroy(GameObject.FindGameObjectWithTag("Enemigo52"));
            DatosPartida.Enemigo52 = true;
        }
    }
    private void ObtenerEstadoPuertas() {

        string datosACargar = GuardarPartida.LeeArchivo(rutaGuardado);
        string[] listaPuertas = datosACargar.Split('_');

        string[] puerta1 = listaPuertas[112].Split(':');
        string[] puerta2 = listaPuertas[113].Split(':');
        string[] puerta3 = listaPuertas[114].Split(':');
        string[] puerta4 = listaPuertas[115].Split(':');
        string[] puerta5 = listaPuertas[116].Split(':');
        string[] puerta6 = listaPuertas[117].Split(':');
        string[] puerta7 = listaPuertas[118].Split(':');

        string puertaEstado1 = puerta1[1];
        string puertaEstado2 = puerta2[1];
        string puertaEstado3 = puerta3[1];
        string puertaEstado4 = puerta4[1];
        string puertaEstado5 = puerta5[1];
        string puertaEstado6 = puerta6[1];
        string puertaEstado7 = puerta7[1];

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
        if (puertaEstado4.Equals("True"))
        {

            Destroy(GameObject.FindGameObjectWithTag("puerta4"));
            DatosPartida.puerta4 = true;
        }
        if (puertaEstado5.Equals("True"))
        {

            Destroy(GameObject.FindGameObjectWithTag("puerta5"));
            DatosPartida.puerta5 = true;
        }
        if (puertaEstado6.Equals("True"))
        {

            Destroy(GameObject.FindGameObjectWithTag("puerta6"));
            DatosPartida.puerta6 = true;
        }
        if (puertaEstado6.Equals("True"))
        {

            Destroy(GameObject.FindGameObjectWithTag("puerta6"));
            DatosPartida.puerta6 = true;
        }
    }
    private void ObtenerEstadoArmadura() {
        string datosACargar = GuardarPartida.LeeArchivo(rutaGuardado);
        string[] listaArmaduraYGolpes = datosACargar.Split('_');

        string[] tipoArmadura = listaArmaduraYGolpes[119].Split(':');
        string[] golpes = listaArmaduraYGolpes[120].Split(':');

        string tipoArmaduraEstado = tipoArmadura[1];
        string golpesEstado = golpes[1];

        switch (tipoArmaduraEstado) {

            case "armaduraMedia":
                AtributosJugador.armaduraEquipada = tipoArmaduraEstado;
                ManejadoraTienda.golpesMedia = int.Parse(golpesEstado);
                break;
            case "armaduraBasica":
                //No cambiar la imagen
                AtributosJugador.armaduraEquipada = tipoArmaduraEstado;
                ManejadoraTienda.golpesBasica = int.Parse(golpesEstado);
                break;

            case "sinArmadura":
                AtributosJugador.armaduraEquipada = tipoArmaduraEstado;
               
                break;
        }
    }
    private void ObtenerEstadoEspada() {
        string datosACargar = GuardarPartida.LeeArchivo(rutaGuardado);
        string[] listaEspada = datosACargar.Split('_');

        string[] tipoEspada = listaEspada[121].Split(':');
       
        string tipoEspadaEstado = tipoEspada[1];

        switch (tipoEspadaEstado) {

            case "espadaMedia":
                AtributosJugador.espadaEquipada = tipoEspadaEstado;
                break;

            case "espadaLegendaria":
                AtributosJugador.espadaEquipada = tipoEspadaEstado;
                break;


        }
        
        
    }
    private void ObtenerObjetosInventario() {
        ObjetoCogible objetos = new ObjetoCogible();
        string datosACargar = GuardarPartida.LeeArchivo(rutaGuardado);
        string[] listaItems = datosACargar.Split('_');

        string[] item1 = new string[2];
        string[] item2 = new string[2];
        string[] item3 = new string[2];
        string[] item4 = new string[2];

        string item1Estado = "";
        string item2Estado = "";
        string item3Estado = "";
        string item4Estado = "";
        


        switch (listaItems.Length - 1) {

            case 122:
                item1 = listaItems[122].Split(':');
                item1Estado = item1[1];
               
                break;
            case 123:
                item1 = listaItems[122].Split(':');
                item2 = listaItems[123].Split(':');
                item1Estado = item1[1];
                item2Estado = item2[1];
                break;
            case 124:
                item1 = listaItems[122].Split(':');
                item2 = listaItems[123].Split(':');
                item3 = listaItems[124].Split(':');
                item1Estado = item1[1];
                item2Estado = item2[1];
                item3Estado = item3[1];

                break;
            case 125:
                item1 = listaItems[122].Split(':');
                item2 = listaItems[123].Split(':');
                item3 = listaItems[124].Split(':');
                item4 = listaItems[125].Split(':');
                item1Estado = item1[1];
                item2Estado = item2[1];
                item3Estado = item3[1];
                item4Estado = item4[1];
                break;
            
        }

        if (item1Estado.Equals("manaInfinito")){
            objetos.instanciarInven(mana);
        } else if (item1Estado.Equals("vidaInfinita")) {
            objetos.instanciarInven(vida);
        }
        else if(item1Estado.Equals("Untagged")){
            objetos.instanciarInven(pocion);
        }


        if (item2Estado.Equals("manaInfinito"))
        {
            objetos.instanciarInven(mana);
        }
        else if (item2Estado.Equals("vidaInfinita"))
        {
            objetos.instanciarInven(vida);
        }
        else if(item2Estado.Equals("Untagged"))
        {
            objetos.instanciarInven(pocion);
        }


        if (item3Estado.Equals("manaInfinito"))
        {
            objetos.instanciarInven(mana);
        }
        else if (item3Estado.Equals("vidaInfinita"))
        {
            objetos.instanciarInven(vida);
        }
        else if (item3Estado.Equals("Untagged"))
        {
            objetos.instanciarInven(pocion);
        }


        if (item4Estado.Equals("manaInfinito"))
        {
            objetos.instanciarInven(mana);
        }
        else if (item4Estado.Equals("vidaInfinita"))
        {
            objetos.instanciarInven(vida);
        }
        else if (item4Estado.Equals("Untagged"))
        {
            objetos.instanciarInven(pocion);
        }

    }
}
