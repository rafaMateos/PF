using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatosInventario : MonoBehaviour
{

    //variables de script
    public static string[] objetosEnInventario = new string[4];

    /// <summary>
    /// funcion interna para añdir objetos al inventario
    /// </summary>
    /// <param name="tagObjeto"></param>
    public static void añadirObjetoAlInventario(string tagObjeto) {

        int cont = -1;
        for (int i = 0; i < objetosEnInventario.Length; i++) {

            if (objetosEnInventario[i] != null && objetosEnInventario[i] != "") {
                cont++;
            }
        }
        objetosEnInventario[cont + 1] = tagObjeto;
        
    }

    /// <summary>
    /// Funcion interna para quitar objetos del inventario
    /// </summary>
    /// <param name="tagObjeto"></param>
    public static void soltarObjetosInventario(string tagObjeto) {

        for (int i = 0; i < objetosEnInventario.Length; i++) {

            if (objetosEnInventario[i] != null) {
                if (objetosEnInventario[i].Equals(tagObjeto))
                {
                    objetosEnInventario[i] = "";
                    break; //Sorry:)
                }
            }
           
        }
    }

}
