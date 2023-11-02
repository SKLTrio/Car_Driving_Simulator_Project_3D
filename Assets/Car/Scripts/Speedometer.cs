using UnityEngine;
using UnityEngine.UI;

public class Speedometer : MonoBehaviour
{
    public Text speedText;
    public Rigidbody carRigidbody;

    public Image Speedometer_Image;
    public Sprite Speedometer_Green;
    public Sprite Speedometer_Yellow;
    public Sprite Speedometer_Red;

    void Update()
    {
        float speed = carRigidbody.velocity.magnitude * 1f; 
        speedText.text = speed.ToString("F1");

        if (speed > 0 && speed <= 8.5)
        {
            Speedometer_Image.sprite = Speedometer_Green;
        }

        else if (speed > 8.5 && speed <= 17)
        {
            Speedometer_Image.sprite = Speedometer_Yellow;
        }

        else if (speed > 17)
        {
            Speedometer_Image.sprite = Speedometer_Red;
        }

        else
        {
            Speedometer_Image.sprite = Speedometer_Green;
        }

    }
}
