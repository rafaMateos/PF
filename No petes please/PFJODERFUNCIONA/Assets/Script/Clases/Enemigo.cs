using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
  
    //Estas clases como enemigo, boos son parecidas ya que son una IA para el movimiento de enemigos

    //Variables de clase
    public float radioDeVision;
    public float radioDeAtaque;
    public static float velocidad = 2;
    bool andando;
    GameObject player;
    Vector3 initialPosition, target;
    Rigidbody2D rb2d;

    void Start()
    {
        
        player = GameObject.FindGameObjectWithTag("Player");
        initialPosition = transform.position;

       
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        target = initialPosition;
        RaycastHit2D hit = Physics2D.Raycast(
            transform.position,
            player.transform.position - transform.position,
            radioDeVision,
            1 << LayerMask.NameToLayer("Default")
      
        );

     
        Vector3 forward = transform.TransformDirection(player.transform.position - transform.position);
        Debug.DrawRay(transform.position, forward, Color.red);

     
        if (hit.collider != null)
        {
            if (hit.collider.tag == "Player")
            {
                target = player.transform.position;
            }
        }

        float distance = Vector3.Distance(target, transform.position);
        Vector3 dir = (target - transform.position).normalized;

        if (target != initialPosition && distance < radioDeAtaque)
        {
            andando = true;
        }
     
        else
        {
            rb2d.MovePosition(transform.position + dir * velocidad * Time.deltaTime);  
        }

        if (target == initialPosition && distance < 0.05f)
        {
            transform.position = initialPosition;

        }

     
        Debug.DrawLine(transform.position, target, Color.green);
    }

    
    void OnDrawGizmosSelected()
    {

        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, radioDeVision);
        Gizmos.DrawWireSphere(transform.position, radioDeAtaque);

    }

   

   

   
}
