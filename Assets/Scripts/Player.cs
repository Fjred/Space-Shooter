using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    public float speed;
    public Rigidbody rb;

    private void Update()
    {
        

        rb.velocity = Vector3.zero;
        if (Input.GetKey(KeyCode.D))
            rb.velocity = new Vector3(speed * Time.deltaTime, 0, 0);
        if (Input.GetKey(KeyCode.A))
            rb.velocity = new Vector3(-speed * Time.deltaTime, 0, 0);
        if (Input.GetKey(KeyCode.W))
            rb.velocity = new Vector3(0, 0, speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.S))
            rb.velocity = new Vector3(0, 0, -speed * Time.deltaTime);

    }
}
