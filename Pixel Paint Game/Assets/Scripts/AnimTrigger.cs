using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AnimTrigger : MonoBehaviour
{
    [SerializeField] private Animator animController;
    [SerializeField] private string animName;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            animController.Play(animName, 0, 0.0f);
        }
    }
}
