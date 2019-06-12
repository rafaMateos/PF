using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventarioController : MonoBehaviour
{

    public void aumentarVida1() {

        ControladorSalud.aumentarVida();
        DatosInventario.soltarObjetosInventario("Untagged");

    }

    

}
