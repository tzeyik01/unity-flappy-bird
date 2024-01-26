using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wing_Flip : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.rotation = Quaternion.Euler(0f, 180f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Euler(0f, 180f, 0f);
    }
}
