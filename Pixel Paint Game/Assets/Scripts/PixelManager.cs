using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PixelManager : MonoBehaviour
{
    public static int pixelTotalCount;

    void Awake()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }
    
    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        GameObject pixelsObject = GameObject.Find("Pixels");
        
        if (pixelsObject != null)
        {
            pixelTotalCount = pixelsObject.transform.childCount;    
            
            Debug.Log("Number of Pixels: " + pixelTotalCount);
        }
        else
        {
            Debug.LogWarning("Pixels GameObject not found!");
        }
    }
    
   
}