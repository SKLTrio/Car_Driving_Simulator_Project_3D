using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

public class Car_Behaviour : MonoBehaviour
{
    [SerializeField]
    Car_Control_Actions Car_Controls;

    [SerializeField]
    public float Move_Max_Speed;

    [SerializeField]
    public float Acceleration;

    [SerializeField]
    public float Deceleration;

    [SerializeField]
    public float Traction;

    [SerializeField]
    public float Steer_Angle = 20;

    private float currentSpeed = 0f;
    private Rigidbody Rigid_Body;

    private void Awake()
    {
        Car_Controls = new Car_Control_Actions();
        Rigid_Body = GetComponent<Rigidbody>();
    }

    private void OnEnable()
    {
        Car_Controls.Enable();
    }

    private void OnDisable()
    {
        Car_Controls.Disable();
    }

    void Update()
    {
        Movement();
    }

    public void Movement()
    {
        // Moving the Car Object.
        Vector3 Move_Input = Car_Controls.Gameplay.Movement.ReadValue<Vector3>();

        // Accelerate
        if (Move_Input.y > 0)
        {
            currentSpeed += Acceleration * Time.deltaTime;
            currentSpeed = Mathf.Min(currentSpeed, Move_Max_Speed);
        }
        // Decelerate or reverse
        else if (Move_Input.y < 0)
        {
            if (currentSpeed > 0)
            {
                currentSpeed -= Deceleration * Time.deltaTime;
            }
            else
            {
                currentSpeed += Deceleration * Time.deltaTime;
            }
            currentSpeed = Mathf.Max(currentSpeed, -Move_Max_Speed);
        }
        else
        {
            // No input, decelerate to stop
            if (currentSpeed > 0)
            {
                currentSpeed -= Deceleration * Time.deltaTime;
                currentSpeed = Mathf.Max(currentSpeed, 0f);
            }
            else if (currentSpeed < 0)
            {
                currentSpeed += Deceleration * Time.deltaTime;
                currentSpeed = Mathf.Min(currentSpeed, 0f);
            }
        }

        // Apply movement using Rigidbody
        Vector3 Move_Force = transform.forward * currentSpeed * Time.deltaTime;
        Rigid_Body.AddForce(Move_Force);

        // Steering
        float Steer_Input = Move_Input.x * Steer_Angle;
        Rigid_Body.AddTorque(Vector3.up * Steer_Input * Time.deltaTime);

        // Traction
        Move_Force *= Traction * Time.deltaTime;
        Rigid_Body.AddForce(Move_Force);
    }
}