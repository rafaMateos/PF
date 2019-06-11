using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class GuardarController : MonoBehaviour
{
    private string rutaGuardado = "C:/Users/" + Environment.UserName + "/Guardado/" + DatosPartida.nombrePartida + ".txt";
  
    string rutaGuardado2 = "C:/Users/" + Environment.UserName + "/Guardado/";
    public static FileInfo[] ficheros;
    public Canvas canvasGuardado;
    public Canvas canvasMenuPausa;
    public Canvas sobreescribir;

   
    public void GuardarPartidaInGame() {

        Directory.CreateDirectory(rutaGuardado2);

       
        DirectoryInfo Dir = new DirectoryInfo(rutaGuardado2);
        ficheros = Dir.GetFiles();

        if (ficheros.Length < 3)
        {
            if (sobreescribir.isActiveAndEnabled) {

                sobreescribir.enabled = false;
            }
            canvasMenuPausa.enabled = false;
            canvasGuardado.enabled = true;
            StartCoroutine(mostrarGuardando());
            Transform posicion_jugador;
            string datosAGuardar = "";

            posicion_jugador = GameObject.FindGameObjectWithTag("Player").transform;
            DatosPartida.PosJugX = posicion_jugador.position.x;
            DatosPartida.PosJugY = posicion_jugador.position.y;

            DatosPartida.dinero = int.Parse(GameObject.FindGameObjectWithTag("dinero").GetComponent<Text>().text);
            DatosPartida.vidas = int.Parse(GameObject.FindGameObjectWithTag("vidas").GetComponent<Text>().text);

            DatosPartida.mana = AtributosJugador.mana;

            //Se que esto es una locura , pero en el momento de guardar tengo que hacer una corrutina, es decir que todos los
            //objetos del mapa se ponen en modo disabled(Unity lo hace por rendimiento), entonces tengo que ir guardando en la clase DatosPartida el estado de cada uno de ellos cuando se interactua con ellos durante la partida
            //y finalmente recuperarlos aqui
            datosAGuardar = "x:" + DatosPartida.PosJugX + "_" + "y:" + DatosPartida.PosJugY
                            + "_" + "cofre1:" + DatosPartida.cofre1 + "_" + "cofre2:" + DatosPartida.cofre2
                            + "_" + "cofre3:" + DatosPartida.cofre3 + "_" + "cofre4:" + DatosPartida.cofre4
                            + "_" + "cofre5:" + DatosPartida.cofre5 + "_" + "cofre6:" + DatosPartida.cofre6
                            + "_" + "cofre7:" + DatosPartida.cofre7 + "_" + "cofre8:" + DatosPartida.cofre8
                            + "_" + "cofre9:" + DatosPartida.cofre9 +"_" + "cofre10:" + DatosPartida.cofre10
                            + "_" + "cofre11:" + DatosPartida.cofre11 + "_" + "cofre12:" + DatosPartida.cofre12
                            + "_" + "cofre13:" + DatosPartida.cofre13 + "_" + "cofre14:" + DatosPartida.cofre14
                            + "_" + "cofre15:" + DatosPartida.cofre15 + "_" + "cofre16:" + DatosPartida.cofre16
                            + "_" + "cofre17:" + DatosPartida.cofre17
                            + "_" + "dinero:" + DatosPartida.dinero + "_" + "vidas:" + DatosPartida.vidas
                            + "_" + "mana:" + DatosPartida.mana
                            + "_" + "moneda1:" + DatosPartida.moneda1 + "_" + "moneda2:" + DatosPartida.moneda2
                            + "_" + "moneda3:" + DatosPartida.moneda3 + "_" + "moneda4:" + DatosPartida.moneda4
                            + "_" + "moneda5:" + DatosPartida.moneda5 + "_" + "moneda6:" + DatosPartida.moneda6
                            + "_" + "moneda7:" + DatosPartida.moneda7 + "_" + "moneda8:" + DatosPartida.moneda8
                            + "_" + "moneda9:" + DatosPartida.moneda9 + "_" + "moneda10:" + DatosPartida.moneda10
                            + "_" + "moneda11:" + DatosPartida.moneda11 + "_" + "moneda12:" + DatosPartida.moneda12
                            + "_" + "moneda13:" + DatosPartida.moneda13 + "_" + "moneda14:" + DatosPartida.moneda14
                            + "_" + "moneda15:" + DatosPartida.moneda15 + "_" + "moneda16:" + DatosPartida.moneda16
                            + "_" + "moneda17:" + DatosPartida.moneda17 + "_" + "moneda18:" + DatosPartida.moneda18
                            + "_" + "moneda19:" + DatosPartida.moneda19 + "_" + "moneda20:" + DatosPartida.moneda20
                            + "_" + "moneda21:" + DatosPartida.moneda21 + "_" + "moneda22:" + DatosPartida.moneda22
                            + "_" + "moneda23:" + DatosPartida.moneda23 + "_" + "moneda24:" + DatosPartida.moneda24
                            + "_" + "moneda25:" + DatosPartida.moneda25 + "_" + "moneda26:" + DatosPartida.moneda26
                            + "_" + "moneda27:" + DatosPartida.moneda27 + "_" + "moneda28:" + DatosPartida.moneda28
                            + "_" + "moneda29:" + DatosPartida.moneda29 + "_" + "moneda30:" + DatosPartida.moneda30
                            + "_" + "moneda31:" + DatosPartida.moneda31 + "_" + "moneda32:" + DatosPartida.moneda32
                            + "_" + "moneda33:" + DatosPartida.moneda33 + "_" + "moneda34:" + DatosPartida.moneda34
                            + "_" + "jarron1:" + DatosPartida.jarron1 + "_" + "jarron2:" + DatosPartida.jarron2
                            + "_" + "jarron3:" + DatosPartida.jarron3 + "_" + "jarron4:" + DatosPartida.jarron4
                            + "_" + "enemigo1:" + DatosPartida.Enemigo1 + "_" + "enemigo2:" + DatosPartida.Enemigo2
                            + "_" + "enemigo3:" + DatosPartida.Enemigo3 + "_" + "enemigo4:" + DatosPartida.Enemigo4
                            + "_" + "enemigo5:" + DatosPartida.Enemigo5 + "_" + "enemigo6:" + DatosPartida.Enemigo6
                            + "_" + "enemigo7:" + DatosPartida.Enemigo7 + "_" + "enemigo8:" + DatosPartida.Enemigo8
                            + "_" + "enemigo9:" + DatosPartida.Enemigo9 + "_" + "enemigo10:" + DatosPartida.Enemigo10
                            + "_" + "enemigo11:" + DatosPartida.Enemigo11 + "_" + "enemigo12:" + DatosPartida.Enemigo12
                            + "_" + "enemigo13:" + DatosPartida.Enemigo13 + "_" + "enemigo14:" + DatosPartida.Enemigo14
                            + "_" + "enemigo14:" + DatosPartida.Enemigo15
                            + "_" + "enemigo16:" + DatosPartida.Enemigo16 + "_" + "enemigo17:" + DatosPartida.Enemigo17
                            + "_" + "enemigo18:" + DatosPartida.Enemigo18 + "_" + "enemigo19:" + DatosPartida.Enemigo19
                            + "_" + "enemigo20:" + DatosPartida.Enemigo20 + "_" + "enemigo21:" + DatosPartida.Enemigo21
                            + "_" + "enemigo22:" + DatosPartida.Enemigo22 + "_" + "enemigo23:" + DatosPartida.Enemigo23
                            + "_" + "enemigo24:" + DatosPartida.Enemigo24 + "_" + "enemigo25:" + DatosPartida.Enemigo25
                            + "_" + "enemigo26:" + DatosPartida.Enemigo26 + "_" + "enemigo1:" + DatosPartida.Enemigo27
                            + "_" + "enemigo3:" + DatosPartida.Enemigo28 + "_" + "enemigo4:" + DatosPartida.Enemigo29
                            + "_" + "enemigo5:" + DatosPartida.Enemigo30 + "_" + "enemigo6:" + DatosPartida.Enemigo31
                            + "_" + "enemigo7:" + DatosPartida.Enemigo32 + "_" + "enemigo8:" + DatosPartida.Enemigo33
                            + "_" + "enemigo9:" + DatosPartida.Enemigo34 + "_" + "enemigo10:" + DatosPartida.Enemigo35
                            + "_" + "enemigo11:" + DatosPartida.Enemigo36 + "_" + "enemigo12:" + DatosPartida.Enemigo37
                            + "_" + "enemigo13:" + DatosPartida.Enemigo38 + "_" + "enemigo14:" + DatosPartida.Enemigo39
                            + "_" + "enemigo16:" + DatosPartida.Enemigo40 + "_" + "enemigo17:" + DatosPartida.Enemigo41
                            + "_" + "enemigo18:" + DatosPartida.Enemigo42+ "_" + "enemigo19:" + DatosPartida.Enemigo43
                            + "_" + "enemigo20:" + DatosPartida.Enemigo44 + "_" + "enemigo21:" + DatosPartida.Enemigo45
                            + "_" + "enemigo22:" + DatosPartida.Enemigo46 + "_" + "enemigo23:" + DatosPartida.Enemigo47
                            + "_" + "enemigo24:" + DatosPartida.Enemigo48 + "_" + "enemigo25:" + DatosPartida.Enemigo49
                            + "_" + "enemigo25:" + DatosPartida.Enemigo50 + "_" + "enemigo25:" + DatosPartida.Enemigo51
                            + "_" + "enemigo25:" + DatosPartida.Enemigo52
                            + "_" + "puerta1:" + DatosPartida.puerta1 +"_" + "puerta2:" + DatosPartida.puerta2
                             + "_" + "puerta3:" + DatosPartida.puerta3 + "_" + "puerta3:" + DatosPartida.puerta4
                               + "_" + "puerta3:" + DatosPartida.puerta5 + "_" + "puerta3:" + DatosPartida.puerta6
                                 + "_" + "puerta3:" + DatosPartida.puerta7; 

            GuardarPartida.EscribeEnArchivo(datosAGuardar, rutaGuardado, true);
           
            GameObject.FindGameObjectWithTag("Player").GetComponent<Movimiento>().velocidad = 6;
            Time.timeScale = 1;

           
           

        }
        else {
            sobreescribir.enabled = true;
        }

        


    }

    IEnumerator mostrarGuardando()
    {
        yield return new WaitForSeconds(2f);
        canvasGuardado.enabled = false;
    }
}
