using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aura : MonoBehaviour {

   //Varibles de script
    public float esperarPulsarParaAtacar;
    Animator animaciones;
    Coroutine gestorManager;
    bool cargado;

    void Start () {
        animaciones = GetComponent<Animator>();
    }

    public void AuraEmpieza() {
        gestorManager = StartCoroutine(Gestor());
        animaciones.Play("Aura_Idle");
    }

    public void AuraAcaba() {
        StopCoroutine(gestorManager);
        animaciones.Play("Aura_Idle");
        cargado = false;
    }

    
    public IEnumerator Gestor() {
        yield return new WaitForSeconds(esperarPulsarParaAtacar);
        animaciones.Play("Aura_Play");
        cargado = true;
    }

   
    public bool estaCargado() {
        return cargado;
    }
}