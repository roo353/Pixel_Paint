using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class BoxTouchBehavior : MonoBehaviour
{
    public SpriteRenderer filled;

    private Transform numberChild;

    void Start()
    {
        numberChild = transform.Find("Number");
        PixelCount();
    }
    private void Update()
    {
        if (ColorManager.numWrongRemaining < 1)
        {
            string currentSceneName = SceneManager.GetActiveScene().name;

            if (currentSceneName == "Drawing1")
            {
                LevelStatus.D1Status = "yes";
            }
            else if (currentSceneName == "Drawing2")
            {
                LevelStatus.D2Status = "yes";
            }
            else if (currentSceneName == "Drawing3")
            {
                LevelStatus.D3Status = "yes";
            }
            else if (currentSceneName == "Drawing4")
            {
                LevelStatus.D4Status = "yes";
            }
            else if (currentSceneName == "Drawing5")
            {
                LevelStatus.D5Status = "yes";
            }
            else if (currentSceneName == "Drawing6")
            {
                LevelStatus.D6Status = "yes";
            }
        }
    }

    public static void PixelCount()
    {
        ColorManager.numWrongRemaining = PixelManager.pixelTotalCount;
    }

    public void OnMouseDown()
    {
        filled.color = ColorManager.currentColor;

        if (gameObject.tag == ColorManager.selectedTag)
        {
            ColorManager.numWrongRemaining -= 1;
            GetComponent<Collider>().enabled = false;
            SceneManager.LoadScene("ImageMenu");
            Debug.Log(ColorManager.numWrongRemaining);
            
            if(numberChild != null)
            {
                numberChild.gameObject.SetActive(!numberChild.gameObject.activeSelf);
            }
        }
    }
    
    void SetTargetInvisible(Transform theTransform)
    {                
        foreach (Transform aaa in theTransform)
        {
            aaa.gameObject.GetComponent<Renderer>().enabled = false;
            SetTargetInvisible(aaa);
        }
    }
}
