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
    }
    private void Update()
    {
        if (ColorManager.numWrongRemaining < 1)
        {
            
        }
    }

    public void OnMouseDown()
    {
        filled.color = ColorManager.currentColor;

        if (gameObject.tag == ColorManager.selectedTag)
        {
            ColorManager.numWrongRemaining -= 1;
            GetComponent<Collider>().enabled = false;
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
