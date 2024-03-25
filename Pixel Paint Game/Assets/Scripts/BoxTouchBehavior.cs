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
            Debug.Log(ColorManager.numWrongRemaining);
        }
    }
}
