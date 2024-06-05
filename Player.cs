using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float speed = 5.0f;
    private float rotationSpeed = 100.0f;
    private float horizontalInput;
    private float verticalInput;
    private float rotationInput;
    private Vector3 moveDirection;

    void Update()
    {
        // Player rotation with Q and E keys
        rotationInput = 0;
        if (Input.GetKey(KeyCode.Q))
        {
            rotationInput = -1;
        }
        if (Input.GetKey(KeyCode.E))
        {
            rotationInput = 1;
        }
        transform.Rotate(0, rotationInput * rotationSpeed * Time.deltaTime, 0);

        // Player rotation with mouse
        float mouseX = Input.GetAxis("Mouse X");
        transform.Rotate(0, mouseX * rotationSpeed * Time.deltaTime, 0);

        // Player movement
        verticalInput = Input.GetAxis("Vertical");

        // Move the player forward in the direction it is facing
        moveDirection = transform.forward * verticalInput;
        moveDirection.Normalize();
        transform.position += moveDirection * speed * Time.deltaTime;
    }
}
