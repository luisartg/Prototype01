using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 10.0f;
    [SerializeField] private float turnSpeed = 25.0f;
    [SerializeField] private string player = "P1";

    private float horizontalInput = 0;
    public float verticalInput = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        MoveVehicleForward();
        MoveVehicleSideways();
    }

    private void MoveVehicleForward()
    {
        verticalInput = Input.GetAxis("Vertical" + player);
        if (player == "P2")
        {
            Debug.Log(verticalInput);
        }

        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
    }

    private void MoveVehicleSideways()
    {
        horizontalInput = Input.GetAxis("Horizontal" + player);
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
