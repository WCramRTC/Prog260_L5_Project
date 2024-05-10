using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeGenerateDemo : MonoBehaviour
{
    public Transform startingPoint;
    public GameObject pipes;
    public float time;
    float countdown;
    // Start is called before the first frame update
    void Start()
    {
        CreatePipe();
        countdown = time;
    }



    // Update is called once per frame
    void Update()
    {
        
        if(countdown > 0) {
            countdown -= Time.deltaTime;
        }
        else {
            CreatePipe();
            countdown = time;

        }

    }

    public void CreatePipe() {
        GameObject newPipe = Instantiate(pipes);
        float randomOffset = Random.Range(-1, 4);
        Vector3 verticalOffset = new Vector3(0,randomOffset,0);

        newPipe.transform.position = startingPoint.position;
        newPipe.transform.Translate(verticalOffset);
        
        
    }
}
