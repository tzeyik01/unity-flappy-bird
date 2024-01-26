using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public Rigidbody2D body;
    public float flapStrength;
    public Logic logic;
    public Boolean isAlive = true;
    public AudioSource wingSFX;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logic>();
    }

    // Update is called once per frame
    void Update()
    {   
        if(transform.position.y < -17 || transform.position.y > 17)
            logic.gameOver();
        
        if (Input.GetKeyDown(KeyCode.Space) && isAlive)
        {
            body.velocity = Vector2.up * flapStrength;
            wingSFX.Play();
        }
                
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
    }
}
