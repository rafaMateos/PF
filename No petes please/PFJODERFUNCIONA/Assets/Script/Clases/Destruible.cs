using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruible : MonoBehaviour
{
    //Variables de clase
    public string estado;
    public float tiempo;
    Animator aniamciones;

    void Start()
    {
        aniamciones = GetComponent<Animator>();
    }

  
    /// <summary>
    /// Eventos de colision gestionar cuando debe de suceder algun evento random y desactivar las que estes activas
    /// </summary>
    /// <param name="col"></param>
    /// <returns></returns>
    IEnumerator OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Ataque")
        {
            aniamciones.Play(estado);
            yield return new WaitForSeconds(tiempo);

            foreach (Collider2D c in GetComponents<Collider2D>())
            {
                c.enabled = false;
            }

        }
        CambiarEstadoJarron();
    }

    /// <summary>
    /// Obtener estado jarrones
    /// </summary>
    private void CambiarEstadoJarron() {

        switch (tag) {

            case "jarron1":
                DatosPartida.jarron1 = true;
                break;

            case "jarron2":
                DatosPartida.jarron2 = true;
                break;

            case "jarron3":
                DatosPartida.jarron3 = true;
                break;

            case "jarron4":
                DatosPartida.jarron4 = true;
                break;
        }
    }

    /// <summary>
    /// Metodo encargado de cancelar la animacion y destruir el objeto
    /// </summary>
    void Update()
    { 
        AnimatorStateInfo stateInfo = aniamciones.GetCurrentAnimatorStateInfo(0);

        if (stateInfo.IsName(estado) && stateInfo.normalizedTime >= 1)
        {
            Destroy(gameObject);
        }

    }
}
