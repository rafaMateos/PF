using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtaqueDistancia : MonoBehaviour
{

    public Vector2 direccionAtaque;
    private float velocidadDeAtaque = 6F;

    private void Update()
    {
        transform.position += new Vector3
            (direccionAtaque.x, direccionAtaque.y, 0) * velocidadDeAtaque * Time.deltaTime;
    }

    private IEnumerator OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.tag.Equals("Player") && !collision.tag.Equals("jefe") && !collision.tag.Equals("Ataque"))
        {
            yield return new WaitForSeconds(0.1f);
            Destroy(gameObject);
        }
    }

}
