using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorSetBehavior : MonoBehaviour
{
    private void OnMouseDown()
    {
        ColorManager.currentColor = GetComponent<SpriteRenderer>().color;
        ColorManager.selectedTag = gameObject.tag;
    }
}
