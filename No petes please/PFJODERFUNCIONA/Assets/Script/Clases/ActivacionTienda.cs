﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivacionTienda : MonoBehaviour
{
    //Atributos script
    public Canvas tienda;
    public static string tagObjetoCocado;

    /// <summary>
    /// Funcion de evento colision la cual se encargara de activar con los datos correspondientes los objetos de la tienda
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.collider.CompareTag("Player")){
            GameObject.FindGameObjectWithTag("Player").GetComponent<Movimiento>().velocidad = 0;
            tienda.enabled = true;
            tagObjetoCocado = gameObject.tag;

            switch (ActivacionTienda.tagObjetoCocado)
            {
                case "salud":
                    ManejadoraTienda.precio = ConstantesTeinda.PRECIOSALUD;
                    ManejadoraTienda.descripTexto = ConstantesTeinda.DESCRIPCIONSALUD;
                    break;

                case "mana":
                    ManejadoraTienda.precio = ConstantesTeinda.PRECIOMANA;
                    ManejadoraTienda.descripTexto = ConstantesTeinda.DESCRIPCIONMANA;
                    break;

                case "espadaMedia":
                    ManejadoraTienda.precio = ConstantesTeinda.PRECIOESPADAMEDIA;
                    ManejadoraTienda.descripTexto = ConstantesTeinda.DESCRIPESPADAMEDIA;
                    break;

                case "espadaLegendaria":
                    ManejadoraTienda.precio = ConstantesTeinda.PRECIOESPALEGENDARIA;
                    ManejadoraTienda.descripTexto = ConstantesTeinda.DESCRIPESPADALEGENDARIA;
                    break;

                case "armaduraMedia":
                    ManejadoraTienda.precio = ConstantesTeinda.PRECIOARMADURAMEDIA;
                    ManejadoraTienda.descripTexto = ConstantesTeinda.DESCRIPARMADURAMEDIA;
                    break;
            }

        }
    }



 
}
