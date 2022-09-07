using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScripts : MonoBehaviour
{
    private float Speed = 5;
    private float addfoceSpeed = 0.5f;
    private float JumpSpeed = 0.04f;
    private Rigidbody rb; //プライベートRigdbodyの名前はrb
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>(); //Rigidbodyを取得
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            float dx = Input.GetAxis("Horizontal");
            float dz = Input.GetAxis("Vertical");
            var movement = new Vector3(dx, 0, dz);
            rb.AddForce(movement * addfoceSpeed);
        }

        if (Input.GetKey(KeyCode.A))
        {
            float dx = Input.GetAxis("Horizontal");
            float dz = Input.GetAxis("Vertical");
            var movement = new Vector3(dx, 0, dz);
            rb.AddForce(movement * addfoceSpeed);
        }

        if (Input.GetKey(KeyCode.S))
        {
            float dx = Input.GetAxis("Horizontal");
            float dz = Input.GetAxis("Vertical");
            var movement = new Vector3(dx, 0, dz);
            rb.AddForce(movement * addfoceSpeed);
        }

        if (Input.GetKey(KeyCode.D))
        {
            float dx = Input.GetAxis("Horizontal");
            float dz = Input.GetAxis("Vertical");
            var movement = new Vector3(dx, 0, dz);
            rb.AddForce(movement * addfoceSpeed);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            Rigidbody rb = GetComponent<Rigidbody>();
            Vector3 foce = new Vector3(0, JumpSpeed, 0);
            rb.AddForce(foce, ForceMode.Impulse);
        }
    }
}
