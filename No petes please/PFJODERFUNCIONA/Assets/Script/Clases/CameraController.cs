using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    
    public Transform objetivo;
    // Start is called before the first frame update
    void Awake()
    {
        objetivo = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(objetivo.position.x, objetivo.position.y, transform.position.z);
    }
}
