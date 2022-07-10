using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float moveSpeed, rotationSpeed;

    private float horizontalInput, verticalInput;

    public Joystick joystick;

    private Rigidbody rb;
    Vector3 move;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {

        horizontalInput =joystick.Horizontal;
        verticalInput =joystick.Vertical;
        move = new Vector3(horizontalInput, 0, verticalInput);

        if(move != Vector3.zero)
        transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation(move), rotationSpeed);

    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + move * moveSpeed * Time.deltaTime);
    }
}
