using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UltimaPosicionTienda : MonoBehaviour
{

    public static Transform posicionSalidaTienda;
    public static Transform posicionEntradaTienda;

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        posicionSalidaTienda = posicionEntradaTienda;
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        posicionEntradaTienda = posicionSalidaTienda;
    }
}
