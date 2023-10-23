using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oil_Spill_Interaction : MonoBehaviour
{
    private void OnTriggerEnter(Collider Collider)
    {
        if (Collider.CompareTag("Car"))
        {
            Car_Behaviour_2 Car_Behaviour_Script = GetComponent<Car_Behaviour_2>();

            if (Car_Behaviour_Script != null)
            {
                Debug.Log("Car found on: " + Car_Behaviour_Script.gameObject.name);
                Car_Behaviour_Script.Current_Speed = 1f;
                Debug.Log("YAAAAAY");
            }

            else
            {
                Debug.Log("BOOOOOO #2");
            }
            
        }

        else
        {
            Debug.Log("BOOOOOO #1");
        }
    }
}
