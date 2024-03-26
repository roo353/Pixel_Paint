using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class BoxTouchBehavior : MonoBehaviour
{
    public SpriteRenderer filled;
    
    public void OnMouseDown()
    {
        filled.color = ColorManager.currentColor;

        if (gameObject.tag == ColorManager.selectedTag)
        {
            ColorManager.numWrongRemaining -= 1;
            GetComponent<Collider>().enabled = false;
            Debug.Log(ColorManager.numWrongRemaining);
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
