using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercntroller : MonoBehaviour
{


    public float moveSpeed;

    float H;
    float V;

    float normVelocityX;
    float normVelocityY;
    float maxSpeed;

    void Start()
    {
        H = Input.GetAxis("Horizontal");
        V = Input.GetAxis("Vertical");

        moveSpeed = 3.0f;

    }


    void Update()
    {

        Keyboard();
        print(GetComponent<Rigidbody2D>().velocity);
    }


    void Keyboard()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, moveSpeed * Time.deltaTime, 0);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, -moveSpeed * Time.deltaTime, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-moveSpeed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(moveSpeed * Time.deltaTime, 0, 0);
        }

    }


}
