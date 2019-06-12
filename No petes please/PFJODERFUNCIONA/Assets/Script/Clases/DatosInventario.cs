using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatosInventario : MonoBehaviour
{

    public static List<string> objetosEnInventario = new List<string>();

    
    public static void añadirObjetoAlInventario(string tagObjeto) {

        objetosEnInventario.Add(tagObjeto);
        
    }

    public static void soltarObjetosInventario(string tagObjeto) {

        for (int i = 0; i < objetosEnInventario.Count; i++) {

            if (objetosEnInventario[i].Equals(tagObjeto)) {

                objetosEnInventario[i] = "";
            }
        }
    }

}
