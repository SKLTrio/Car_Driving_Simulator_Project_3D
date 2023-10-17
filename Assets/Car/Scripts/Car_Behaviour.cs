using UnityEngine;
using UnityEngine.InputSystem;

public class Car_Behaviour : MonoBehaviour
{
    private Rigidbody Rigid_Body;
    private Car_Control_Actions Car_Input_Controls;

    [SerializeField]
    private GameObject First_Person_Camera;

    [SerializeField]
    private GameObject Third_Person_Camera;

    [SerializeField]
    private float Max_Speed = 5f;

    [SerializeField] 
    private float Acceleration_Speed = 1f;

    [SerializeField] 
    private float Deceleration_Speed = 2.5f;

    [SerializeField] 
    private float Steer_Angle = 5f;

    [SerializeField] 
    private float Steer_Speed = 0.015f;

    private float Current_Speed = 0f;

    private void Awake()
    {
        Car_Input_Controls = new Car_Control_Actions();
        Rigid_Body = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        First_Person_Camera.SetActive(true);
        Third_Person_Camera.SetActive(false);
    }

    private void OnEnable()
    {
        Car_Input_Controls.Enable();
    }

    private void OnDisable()
    {
        Car_Input_Controls.Disable();
    }

    void Update()
    {
        Movement();
    }

    public void Movement()
    {
        Vector2 Move_Input = Car_Input_Controls.Gameplay.Movement.ReadValue<Vector2>();
        float Accelerate_Input = Move_Input.y;

        if (Accelerate_Input > 0)
        {
            Current_Speed = Mathf.MoveTowards(Current_Speed, Max_Speed, Acceleration_Speed * Time.deltaTime);
        }

        else if (Accelerate_Input < 0)
        {
            Current_Speed = Mathf.MoveTowards(Current_Speed, -Max_Speed, Deceleration_Speed * Time.deltaTime);
        }

        else
        {
            Current_Speed = Mathf.MoveTowards(Current_Speed, 0f, Deceleration_Speed * Time.deltaTime);
        }

        Vector3 Move_Force = transform.forward * Current_Speed;
        Rigid_Body.AddForce(Move_Force);

        float Steer_Input = Move_Input.x * Steer_Speed;
        float Turn_Amount = Steer_Input * Steer_Angle;

        Quaternion Turn_Rotation = Quaternion.Euler(0f, Turn_Amount, 0f);
        Rigid_Body.MoveRotation(Rigid_Body.rotation * Turn_Rotation);

        Rigid_Body.AddForce(Move_Force);
    }

    public void Camera_Switch()
    {
        if (Car_Input_Controls.Gameplay.Camera_Switch.triggered)
        {
            Debug.Log("BUTTON PRESSED");
            if (First_Person_Camera.activeSelf)
            {
                Debug.Log("FIRST PERSON ACTIVE");
                First_Person_Camera.SetActive(false);
                Third_Person_Camera.SetActive(true);

            }

            else if (Third_Person_Camera.activeSelf)
            {
                Debug.Log("THIRD PERSON ACTIVE");
                Third_Person_Camera.SetActive(false);
                First_Person_Camera.SetActive(true);
            }
        }
    }
}