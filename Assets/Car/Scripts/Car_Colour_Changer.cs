using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car_Colour_Changer : MonoBehaviour
{
    [SerializeField] private Color chosenColor;
    [SerializeField] private Material sharedMaterial;
    [SerializeField] private GameObject objectToChange1;
    [SerializeField] private GameObject objectToChange2;

    private void Start()
    {
        // Load the chosen color from PlayerPrefs
        string savedColor = PlayerPrefs.GetString("Chosen_Colour");

        if (!string.IsNullOrEmpty(savedColor))
        {
            Debug.Log(savedColor);
            Debug.Log("WOOHOOO");
            if (ColorUtility.TryParseHtmlString(savedColor, out Color loadedColor))
            {
                Debug.Log("YAAAAY");
                chosenColor = loadedColor;
            }
            else
            {
                chosenColor = Color.white;
            }

            // Change the materials of the objects
            ChangeObjectMaterials(objectToChange1);
            ChangeObjectMaterials(objectToChange2);
        }
    }

    private void ChangeObjectMaterials(GameObject obj)
    {
        Renderer objectRenderer = obj.GetComponent<Renderer>();
        if (objectRenderer != null)
        {
            objectRenderer.material = sharedMaterial; // Assign the shared material to the object.
            objectRenderer.material.color = chosenColor; // Change the color of the shared material.
        }
    }

    public void ResetCarColor()
    {
        chosenColor = Color.white;
        ChangeObjectMaterials(objectToChange1);
        ChangeObjectMaterials(objectToChange2);
    }
}





