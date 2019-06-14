using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScorePoint : MonoBehaviour
{

    public static int puntos = 500;
    public string textoMostrar = "";

    public Text Texto;

    public static ScorePoint scorePoint;
    

    private void Awake()
    {
        scorePoint = this; //Singleton
    }
   
    void Update()
    {
        if (Texto != null) {
            Texto.text = textoMostrar + " " + puntos.ToString();
        }
    }
}
