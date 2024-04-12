using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PixelManager : MonoBehaviour
{
    // Public variable to hold the count
    public static int pixelTotalCount;

    void Start()
    {
        // Find the GameObject named "Pixels"
        GameObject pixelsObject = GameObject.Find("Pixels");

        // Check if the GameObject is found
        if (pixelsObject != null)
        {
            // Count the children of the "Pixels" GameObject
            pixelTotalCount = pixelsObject.transform.childCount;
            
            // Output the count
            Debug.Log("Number of Pixels: " + pixelTotalCount);
        }
        else
        {
            Debug.LogWarning("Pixels GameObject not found!");
        }
    }
}