using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;

    public float turnSpeed;

    public float maxSpeed;

    public Rigidbody rb;

    bool canTurn = false;

    public float speedStep;

    // Start is called before the first frame update
    void Start()
    {
        maxSpeed = speed;
        rb = GetComponent<Rigidbody>();
        speed = 0;
        rb.constraints = RigidbodyConstraints.FreezeRotation;
    }

    // Update is called once per frame
    void Update()
    {
        if (canTurn)
        {
            Vector3 turnInput = new Vector3(0, Input.GetAxisRaw("Horizontal"), 0);
            transform.Rotate(turnInput.x, turnInput.y * turnSpeed, turnInput.z);
        }

        rb.velocity = (transform.forward * speed);

        if (Input.GetKey("w"))
        {
            canTurn = true;
            speed = maxSpeed;
        }

        else if (Input.GetKey("s"))
        {
            canTurn = true;
            speed = -maxSpeed;
        }
        else
        {
            canTurn = false;
            speed = Mathf.Lerp(speed, 0, speedStep);
        }
    }
}