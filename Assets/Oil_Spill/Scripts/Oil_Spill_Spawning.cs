using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oil_Spill_Spawning : MonoBehaviour
{
    public GameObject Oil_Spill_Prefab;
    public int Spill_Spawn_Amount = 5;

    // Start is called before the first frame update
    void Start()
    {
        Transform Parent_Transform = transform;

        // Get all the spawn points in the scene.
        GameObject[] All_Spawn_Points = GameObject.FindGameObjectsWithTag("Oil_Spill_Spawn_Point");

        if (All_Spawn_Points.Length == 0)
        {
            Debug.LogError("No spawn points found.");
            return;
        }

        // Make sure the number of keys to spawn is not more than available spawn points.
        Spill_Spawn_Amount = Mathf.Min(Spill_Spawn_Amount, All_Spawn_Points.Length);

        for (int i = 0; i < Spill_Spawn_Amount; i++)
        {
            // Pick a random spawn point.
            int Random_Point = Random.Range(0, All_Spawn_Points.Length);
            Vector3 Spawn_Position = All_Spawn_Points[Random_Point].transform.position;

            // Instantiate a new key at the selected position.
            GameObject New_Oil_Spill = Instantiate(Oil_Spill_Prefab, Spawn_Position, Quaternion.identity);
            New_Oil_Spill.transform.parent = Parent_Transform;
        }
    }
}