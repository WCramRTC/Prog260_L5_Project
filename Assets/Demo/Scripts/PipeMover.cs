using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMover : MonoBehaviour
{

    GameObject pipe;
    public float speed = 5;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = Vector3.back * speed * Time.deltaTime;
        transform.Translate(movement);
    }

    private void OnTriggerEnter(Collider other) {

        Debug.Log("This works");
        if(other.gameObject.tag == "Finish") {
            Destroy(gameObject);
        }
    }

}
