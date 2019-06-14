using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtaqueDistancia : MonoBehaviour
{
    //Atributos script
    public Vector2 direccionAtaque;
    private float velocidadDeAtaque = 6F;
    /// <summary>
    /// Funcion update la cual cambiara la posicion del ataque a distancia
    /// </summary>
    private void Update()
    {
        transform.position += new Vector3
            (direccionAtaque.x, direccionAtaque.y, 0) * velocidadDeAtaque * Time.deltaTime;
    }

    /// <summary>
    /// Evento trigguer el cual destruira el objeto al colisionar con algo sobre el mapa
    /// </summary>
    /// <param name="collision"></param>
    /// <returns></returns>
    private IEnumerator OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.tag.Equals("Player") && !collision.tag.Equals("jefe") && !collision.tag.Equals("Ataque"))
        {
            yield return new WaitForSeconds(0.1f);
            Destroy(gameObject);
        }
    }

}
