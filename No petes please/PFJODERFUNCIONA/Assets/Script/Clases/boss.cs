using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss : MonoBehaviour
{
    public float visionRadius;
    public float attackRadius = 1;
    public float speed;
    private float speedMAX;
    GameObject player;
    Vector3 initialPosition, target;

    Animator animaciones;
    Rigidbody2D rb2d;



    void Start()
    {
        animaciones = GetComponent<Animator>();
        speedMAX = speed;
       
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
            animaciones.SetBool("atacando", true);
            animaciones.SetFloat("movX", dir.x);
            animaciones.SetFloat("movY", dir.y);

        }
       
        else
        {
            rb2d.MovePosition(transform.position + dir * speed * Time.deltaTime);
            animaciones.SetBool("atacando", false);
          

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
