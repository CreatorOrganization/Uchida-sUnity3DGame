using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Scripts : MonoBehaviour
{
    private float speed = 0.9f;
    private float addfocespeed = 0.7f;
    private float JumpSpeed = 0.09f;
    private Rigidbody rb; 
   // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            float dx = Input.GetAxis("Horizontal");
            float dz = Input.GetAxis("Vertical");
            var movement = new Vector3(dx, 0, dz);
            rb.AddForce(movement * speed);
        }
        if(Input.GetKey(KeyCode.A))
        {

            float dx = Input.GetAxis("Horizontal");
            float dz = Input.GetAxis("Vertical");
            var movement = new Vector3(dx, 0, dz);
            rb.AddForce(movement * speed);
        }
        if(Input.GetKey(KeyCode.S))
        {

            float dx = Input.GetAxis("Horizontal");
            float dz = Input.GetAxis("Vertical");
            var movement = new Vector3(dx, 0, dz);
            rb.AddForce(movement * speed);
        }
        if(Input.GetKey(KeyCode.D))
        {

            float dx = Input.GetAxis("Horizontal");
            float dz = Input.GetAxis("Vertical");
            var movement = new Vector3(dx, 0, dz);
            rb.AddForce(movement * speed);
        }
        if(Input.GetKey(KeyCode.Space))
        {
            Rigidbody rb = GetComponent<Rigidbody>();
            Vector3 foce = new Vector3(0, JumpSpeed, 0);
            rb.AddForce(foce, ForceMode.Impulse);
        }
    }
}
