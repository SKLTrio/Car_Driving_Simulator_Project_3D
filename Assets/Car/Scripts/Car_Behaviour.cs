using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

public class Car_Behaviour : MonoBehaviour
{
    [SerializeField]
    Car_Control_Actions Car_Controls;

    [SerializeField]
    public float Move_Speed;

    private void Awake()
    {
        Car_Controls = new Car_Control_Actions();
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
        Vector3 Move_Input = Car_Controls.Gameplay.Movement.ReadValue<Vector3>();
        Vector3 Move_Force = Move_Input * Move_Speed * Time.deltaTime;
        transform.Translate(Move_Force, 0);
    }
}
