using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class GuardarPartida : MonoBehaviour
{

    public static void EscribeEnArchivo(string contenido, string rutaArchivo, bool sobrescribir = true)
    {
        StreamWriter sw = new StreamWriter(rutaArchivo, !sobrescribir);
        sw.Write(contenido);
        sw.Close();
    }

    public static string LeeArchivo(string rutaArchivo)
    {
        StreamReader sr = new StreamReader(rutaArchivo);
        string contenido = sr.ReadLine();
        Debug.Log(contenido);
        sr.Close();
        return contenido;
    }
 

}
