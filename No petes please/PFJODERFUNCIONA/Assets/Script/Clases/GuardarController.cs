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

            datosAGuardar = "x:" + DatosPartida.PosJugX + "_" + "y:" + DatosPartida.PosJugY
                            + "_" + "cofre1:" + DatosPartida.cofre1 + "_" + "cofre2:" + DatosPartida.cofre2
                            + "_" + "cofre3:" + DatosPartida.cofre3 + "_" + "cofre4:" + DatosPartida.cofre4
                            + "_" + "cofre5:" + DatosPartida.cofre5 + "_" + "cofre6:" + DatosPartida.cofre6
                            + "_" + "cofre7:" + DatosPartida.cofre7 + "_" + "cofre8:" + DatosPartida.cofre8
                            + "_" + "dinero:" + DatosPartida.dinero + "_" + "vidas:" + DatosPartida.vidas
                            + "_" + "mana:" + DatosPartida.mana
                            + "_" + "moneda1:" + DatosPartida.moneda1 + "_" + "moneda2:" + DatosPartida.moneda2
                            + "_" + "moneda3:" + DatosPartida.moneda3 + "_" + "moneda4:" + DatosPartida.moneda4
                             + "_" + "moneda5:" + DatosPartida.moneda5 + "_" + "moneda6:" + DatosPartida.moneda6
                              + "_" + "moneda7:" + DatosPartida.moneda7 + "_" + "moneda8:" + DatosPartida.moneda8
                            + "_" + "jarron1:" + DatosPartida.jarron1 + "_" + "jarron2:" + DatosPartida.jarron2
                            + "_" + "jarron3:" + DatosPartida.jarron3 + "_" + "jarron4:" + DatosPartida.jarron4
                            + "_" + "enemigo1:" + DatosPartida.Enemigo1 + "_" + "enemigo2:" + DatosPartida.Enemigo2
                            + "_" + "enemigo3:" + DatosPartida.Enemigo3 + "_" + "enemigo4:" + DatosPartida.Enemigo4
                            + "_" + "enemigo5:" + DatosPartida.Enemigo5 + "_" + "enemigo6:" + DatosPartida.Enemigo6
                            + "_" + "enemigo7:" + DatosPartida.Enemigo7 + "_" + "enemigo8:" + DatosPartida.Enemigo8
                            + "_" + "puerta1:" + DatosPartida.puerta1 +"_" + "puerta2:" + DatosPartida.puerta2
                             + "_" + "puerta3:" + DatosPartida.puerta3; 

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
