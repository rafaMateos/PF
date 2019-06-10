using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtaqueJefe : MonoBehaviour
{
    private bool esAtaqueJefe;

    private void Awake()
    {
        InvokeRepeating("ataqueJefe", 1f, 1f);
    }
    private void Start()
    {
        esAtaqueJefe = false;
    }

    private void Update()
    {
        esAtaqueJefe = GetComponent<Animator>().GetBool("atacando");
    }

    void ataqueJefe()
    {

        if (esAtaqueJefe)
            ControladorSalud.DisminuirVida();
    }
}
