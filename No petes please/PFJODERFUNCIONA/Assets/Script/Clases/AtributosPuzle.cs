using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtributosPuzle : MonoBehaviour
{

    public static string ultimaPalanca;
    public static bool estaEnPalanca;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        ultimaPalanca = tag;
        estaEnPalanca = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        ultimaPalanca = "";
        estaEnPalanca = false;
    }
}
