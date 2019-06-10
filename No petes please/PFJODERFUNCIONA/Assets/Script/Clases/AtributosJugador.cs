using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AtributosJugador : MonoBehaviour
{

    public static int vidas = 999;
    public static float mana = 1;
    public static AtributosJugador atributosJugador;
    public Text Texto;
    private RectTransform Mana;
    public static bool tieneMana = true;
    public static string espadaEquipada;
    public static string armaduraEquipada;
    public static bool botasRapidas;
    public static bool vidainfinita;
    public static bool manaInfinito;

    private void Start()
    {
        espadaEquipada = "espadaBasica";
        armaduraEquipada = "armaduraBasica";
        atributosJugador = this;
        Mana = GetComponent<RectTransform>();
    }

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
