using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Car_Behaviour_2 : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed;
    [SerializeField]
    private float maxSpeed;
    [SerializeField]
    private float acceleration;
    [SerializeField]
    private float deceleration;
    [SerializeField]
    private float steerAngle = 20;
    [SerializeField]
    private Transform Pivot_Point;

    private float currentSpeed = 0f;
    private Vector2 moveInput;

    private void OnEnable()
    {
        // Enable the car controls.
        var carControls = new Car_Control_Actions();
        carControls.Enable();

        // Bind the move action to the MovePerformed event.
        var moveAction = carControls.Gameplay.Movement;
        moveAction.performed += OnMovePerformed;
        moveAction.canceled += OnMoveCanceled;
    }

    private void OnDisable()
    {
        // Disable the car controls.
        var carControls = new Car_Control_Actions();
        carControls.Disable();

        // Unbind the move action from the events.
        var moveAction = carControls.Gameplay.Movement;
        moveAction.performed -= OnMovePerformed;
        moveAction.canceled -= OnMoveCanceled;
    }

    private void OnMovePerformed(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
    }

    private void OnMoveCanceled(InputAction.CallbackContext context)
    {
        moveInput = Vector2.zero;
    }

    private void Update()
    {
        MoveForward();
        Turn();
    }

    private void MoveForward()
    {
        // Accelerate
        if (moveInput.y > 0)
        {
            currentSpeed += acceleration * Time.deltaTime;
            currentSpeed = Mathf.Min(currentSpeed, maxSpeed);
        }
        // Decelerate or reverse
        else if (moveInput.y < 0)
        {
            currentSpeed -= deceleration * Time.deltaTime;
            currentSpeed = Mathf.Max(currentSpeed, -maxSpeed);
        }
        else
        {
            // No input, decelerate to stop
            if (currentSpeed > 0)
            {
                currentSpeed -= deceleration * Time.deltaTime;
                currentSpeed = Mathf.Max(currentSpeed, 0f);
            }
            else if (currentSpeed < 0)
            {
                currentSpeed += deceleration * Time.deltaTime;
                currentSpeed = Mathf.Min(currentSpeed, 0f);
            }
        }

        // Apply movement relative to the car's local forward vector
        Vector3 moveForce = transform.forward * currentSpeed * Time.deltaTime;
        transform.Translate(moveForce);
    }

    private void Turn()
    {
        float steerInput = moveInput.x;
        float rotationAmount = steerInput * steerAngle * Time.deltaTime;
        float turnSpeed = 5.0f;

        // Rotate the pivot point around the car's center point
        Pivot_Point.Rotate(Vector3.up, rotationAmount);

        // Rotate the car model itself based on the pivot point's rotation
        transform.rotation = Quaternion.Slerp(transform.rotation, Pivot_Point.rotation, turnSpeed * Time.deltaTime);

    }
}