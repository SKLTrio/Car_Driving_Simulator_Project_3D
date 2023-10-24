using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LapTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Collider>().isTrigger = true;
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Car")
        {
            Lap();
        }
    }

    public void Lap()
    {        
        GameManager.LapCounter();        
    }

}
