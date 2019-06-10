using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestorAtaquesPasillo : MonoBehaviour
{
    public GameObject ataquePrefab;
    Vector3 target;
    GameObject player;
    public float attackRadius;
    public Animator anim;
    float distance = 0;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        anim = GetComponent<Animator>();

    }
    private void Awake()
    {
        InvokeRepeating("atacarJugador", 0.9f, 0.9f);
    }

    void atacarJugador()
    {
        if (!GetComponent<SaludEnemigosEstaticos>().estaMuerto) {
            target = player.transform.position;
            distance = Vector3.Distance(target, transform.position);


            if (distance < attackRadius)
            {
                if (anim != null)
                {
                    anim.Play("ataqueflecha");
                }
                Instantiate(ataquePrefab, transform.position, ataquePrefab.transform.rotation);
            }
            else
            {

                anim.Play("iddle");
            }
        }
        

    }

    private void Update()
    {
        if (transform.position.x > GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>().position.x)
        {

            GetComponent<SpriteRenderer>().flipX = true;


        }
        else
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }
    }
}
