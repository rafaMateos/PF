using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MostraCargarPartida : MonoBehaviour
{

    public Canvas canvasCargar;

    public void mostarCargar() {
        canvasCargar.enabled = true;
    }

    public void NOmostarCargar(){
        canvasCargar.enabled = false;
    }


}
