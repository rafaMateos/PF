using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorSalud : MonoBehaviour
{
    /// <summary>
    /// Metodo para aumentar vida al jugador
    /// </summary>
    public static void aumentarVida()
    {
        AtributosJugador.vidas++;
    }

    /// <summary>
    /// Metodo para aumentar vida por pocion
    /// </summary>
    public static void aumentarVidaPocion()
    {
        AtributosJugador.vidas += 10;
    }

    /// <summary>
    /// Metodo para disminuir la vida del juagador segun armadura equipada
    /// </summary>
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

    /// <summary>
    /// Metodo para disminuir vida por flecha
    /// </summary>
    public static void disminuirVidaPorFlecha() {
        AtributosJugador.vidas -= 1;
    }

    /// <summary>
    /// Metodo para aumentar vida por compra
    /// </summary>
    public static void aumentarVidaPorCompra()
    {
        AtributosJugador.vidas += 50;
    }

    /// <summary>
    /// Metodo para recargar el mana
    /// </summary>
    public static void recargarMana() {

        AtributosJugador.mana = 1;
    }


}
