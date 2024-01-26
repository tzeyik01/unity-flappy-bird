using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMove : MonoBehaviour
{
    public float speed = 5;
    public float deadZone = -45;

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * speed) * Time.deltaTime;

        if (transform.position.x < deadZone)
        {
            Debug.Log("Pipe deleted");
            Destroy(gameObject);
        }
            
    }
}
