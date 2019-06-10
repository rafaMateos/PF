using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScorePoint : MonoBehaviour
{

    public static int puntos = 100;
    public string textoMostrar = "";

    public Text Texto;

    public static ScorePoint scorePoint;
    // Start is called before the first frame update

    private void Awake()
    {
        scorePoint = this;
    }
    // Update is called once per frame
    void Update()
    {
        if (Texto != null) {
            Texto.text = textoMostrar + " " + puntos.ToString();
        }
    }
}
