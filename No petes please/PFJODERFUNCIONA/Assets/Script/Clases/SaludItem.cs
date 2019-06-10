using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaludItem : MonoBehaviour
{

    private Transform player;
    private AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        audio = GetComponent<AudioSource>();
    }

    

    public void usar() {

        audio.Play();
        new WaitForSeconds(1);
        Destroy(gameObject);

    }


}
