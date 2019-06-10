using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
  
    // Variables para gestionar el radio de visión, el de ataque y la velocidad
    public float visionRadius;
    public float attackRadius;
    public static float speed = 2;

    GameObject player;
    Vector3 initialPosition, target;
    //Animator anim;
    Rigidbody2D rb2d;

    void Start()
    {
        
        player = GameObject.FindGameObjectWithTag("Player");
        initialPosition = transform.position;

        //anim = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        target = initialPosition;
        RaycastHit2D hit = Physics2D.Raycast(
            transform.position,
            player.transform.position - transform.position,
            visionRadius,
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

        if (target != initialPosition && distance < attackRadius)
        {
           // anim.SetFloat("movX", dir.x);
           // anim.SetFloat("movY", dir.y);
           // anim.Play("Enemy_Walk", -1, 0);  
        }
     
        else
        {
            rb2d.MovePosition(transform.position + dir * speed * Time.deltaTime);  
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
        Gizmos.DrawWireSphere(transform.position, visionRadius);
        Gizmos.DrawWireSphere(transform.position, attackRadius);

    }

   

   

   
}
