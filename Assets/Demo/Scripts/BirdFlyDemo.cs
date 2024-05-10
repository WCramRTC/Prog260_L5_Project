using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdFlyDemo : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rb;
    public float flyForce;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump")) {
            rb.AddForce(Vector3.up * flyForce, ForceMode.Impulse);
        }
    }
}
