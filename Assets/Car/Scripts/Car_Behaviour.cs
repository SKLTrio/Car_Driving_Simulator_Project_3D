using UnityEngine;
using UnityEngine.InputSystem;

public class Car_Behaviour : MonoBehaviour
{
    private Rigidbody Rigid_Body;
    private Car_Control_Actions Car_Input_Controls;

    [SerializeField]
    private float Max_Speed = 10f;

    [SerializeField] 
    private float Acceleration_Speed = 1f;

    [SerializeField] 
    private float Deceleration_Speed = 1f;

    [SerializeField]
    private float Deceleration_Speed_Over_Time = 0.25f;

    [SerializeField] 
    private float Steer_Angle = 10f;

    [SerializeField]
    private float Steer_Speed = 0.02f;

    private float Current_Speed = 0f;

    public bool Is_Grounded;

    public GameObject Car;

    private void Awake()
    {
        Car_Input_Controls = new Car_Control_Actions();
        Rigid_Body = GetComponent<Rigidbody>();
    }

    private void OnEnable()
    {
        Car_Input_Controls.Gameplay.Enable();
    }

    private void OnDisable()
    {
        Car_Input_Controls.Gameplay.Disable();
    }

    void Update()
    {
        Movement();
    }

    public void Movement()
    {
        Vector2 Move_Input = Car_Input_Controls.Gameplay.Accelerate.ReadValue<Vector2>();
        float Accelerate_Input = Move_Input.y;

        if (Is_Grounded)
        {
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
                Current_Speed = Mathf.MoveTowards(Current_Speed, 0f, Deceleration_Speed_Over_Time * Time.deltaTime);
            }
        }


        Vector3 Move_Force = transform.forward * Current_Speed;
        Rigid_Body.AddForce(Move_Force);

        float Steer_Input = Move_Input.x * Steer_Speed;
        float Turn_Amount = Steer_Input * Steer_Angle;

        if (Turn_Amount > 0 || Turn_Amount < 0 && Is_Grounded)
        {
            Rigid_Body.drag = 4.5f;
        }

        else
        {
            Rigid_Body.drag = 3f;
        }

        Quaternion Turn_Rotation = Quaternion.Euler(0f, Turn_Amount, 0f);
        Rigid_Body.MoveRotation(Rigid_Body.rotation * Turn_Rotation);

        Rigid_Body.AddForce(Move_Force);

        float Y_Rotation_Position = Car.transform.rotation.eulerAngles.y;

        if (Is_Grounded && Car.transform.rotation.eulerAngles.x == 80f)
        {
            Debug.Log("ROTATED 1");
            Vector3 New_Rotation = new Vector3(0, Y_Rotation_Position, 0);
            Car.transform.eulerAngles = New_Rotation;
            Current_Speed = 0f;
        }

        else if (!Is_Grounded && Car.transform.rotation.eulerAngles.x < -100f && Car.transform.rotation.eulerAngles.x >= 120f) {
            Debug.Log("ROTATED 2");
            Vector3 New_Rotation = new Vector3(0, Y_Rotation_Position, 0);
            Car.transform.eulerAngles = New_Rotation;
            Current_Speed = 0f;
        }

        else if (!Is_Grounded && Car.transform.rotation.eulerAngles.z > -100f && Car.transform.rotation.eulerAngles.z >= 80f)
        {
            Debug.Log("ROTATED 3");
            Vector3 New_Rotation = new Vector3(0, Y_Rotation_Position, 0);
            Car.transform.eulerAngles = New_Rotation;
            //Current_Speed = 0f;
        }

    }

    public void Brake()
    {
        Current_Speed = 0.75f;
    }

    private void OnCollisionEnter(Collision Collider)
    {
        if (Collider.gameObject.CompareTag("Ground"))
        {
            Debug.Log("IS GROUNDED");
            Is_Grounded = true;
        }
    }

    private void OnCollisionExit(Collision Collider)
    {
        if (Collider.gameObject.CompareTag("Ground"))
        {
            Is_Grounded = false;
        }
    }
}