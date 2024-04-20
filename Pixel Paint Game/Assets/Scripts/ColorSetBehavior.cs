using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorSetBehavior : MonoBehaviour
{
    public AudioSource audioSource;

    private void Start()
    {
        if (audioSource == null)
            audioSource = GetComponent<AudioSource>();
    }

    private void OnMouseDown()
    {
        ColorManager.currentColor = GetComponent<SpriteRenderer>().color;
        ColorManager.selectedTag = gameObject.tag;
        
        if (audioSource != null && !audioSource.isPlaying)
        {
            audioSource.Play();
        }
    }
}
