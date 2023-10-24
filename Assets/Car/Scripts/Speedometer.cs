using UnityEngine;
using UnityEngine.UI;

public class Speedometer : MonoBehaviour
{
    public Text speedText;
    public Rigidbody carRigidbody;

    void Update()
    {
        float speed = carRigidbody.velocity.magnitude * 1f; 
        speedText.text = speed.ToString("F1");

    }
}
