using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorSalud : MonoBehaviour
{

    public static void aumentarVida()
    {
        AtributosJugador.vidas++;
    }
    
    public static void DisminuirVida()
    {
        if (!AtributosJugador.vidainfinita) {
            switch (AtributosJugador.armaduraEquipada)
            {

                case "armaduraMedia":
                    AtributosJugador.vidas -= 3;
                    ManejadoraTienda.golpesMedia--;
                    GameObject.FindGameObjectWithTag("hitJugador").GetComponent<AudioSource>().Play();
                    break;

                case "armaduraBasica":
                    AtributosJugador.vidas -= 5;
                    ManejadoraTienda.golpesBasica--;
                    GameObject.FindGameObjectWithTag("hitJugador").GetComponent<AudioSource>().Play();
                    break;

                case "sinArmadura":
                    AtributosJugador.vidas -= 15;
                    GameObject.FindGameObjectWithTag("hitJugador").GetComponent<AudioSource>().Play();
                    break;

            }
        }
       
       
       
    }

    public static void disminuirVidaPorFlecha() {
        AtributosJugador.vidas -= 1;
    }

    public static void aumentarVidaPorCompra()
    {
        AtributosJugador.vidas += 5;
    }

    public static void recargarMana() {

        AtributosJugador.mana = 1;
    }


}
