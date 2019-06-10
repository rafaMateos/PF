using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PausaController : MonoBehaviour
{
    private Canvas MenuPausa;
    private bool esPausado;
    // Start is called before the first frame update
    void Start()
    {
        esPausado = false;
        MenuPausa = GetComponent<Canvas>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !esPausado)
        {
            MenuPausa.enabled = true;
            esPausado = true;
            Time.timeScale = 0;
        }
        else if(Input.GetKeyDown(KeyCode.Escape) && esPausado){
            MenuPausa.enabled = false;
            esPausado = false;
            Time.timeScale = 1;
        }
    }
}
