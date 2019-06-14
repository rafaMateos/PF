using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AtributosJugador : MonoBehaviour
{

    //Varibles de script
    public static int vidas = 300;
    public static float mana = 1;
    public static AtributosJugador atributosJugador;
    public Text Texto;
    private RectTransform Mana;
    public static bool tieneMana = true;
    public static string espadaEquipada = "espadaBasica";
    public static string armaduraEquipada = "armaduraBasica";
    public static bool botasRapidas;
    public static bool vidainfinita;
    public static bool manaInfinito;
    public static bool tieneLlave;
    

    /// <summary>
    /// 
    /// </summary>
    private void Start()
    {
        atributosJugador = this;
        Mana = GetComponent<RectTransform>();
    }

    /// <summary>
    /// Metodo update el cual gestiona el valor de las variables asincronas del jugador
    /// </summary>
    private void Update()
    {
       
        Texto.text = vidas.ToString();
        if (Mana != null) {
            Mana.localScale = new Vector3(mana, 1, 1);
            if (mana <= 0)
            {
                tieneMana = false;
            }
            else
            {
                tieneMana = true;
            }
        }
        
    }

    

}
