using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtributosPuzle : MonoBehaviour
{
    /// <summary>
    /// Varibles de script
    /// </summary>
    public static string ultimaPalanca;
    public static bool estaEnPalanca;

    /// <summary>
    /// Evento de entrada de colision
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionEnter2D(Collision2D collision)
    {
        ultimaPalanca = tag;
        estaEnPalanca = true;
    }

    /// <summary>
    /// Evento de salida de colision
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionExit2D(Collision2D collision)
    {
        ultimaPalanca = "";
        estaEnPalanca = false;
    }
}
