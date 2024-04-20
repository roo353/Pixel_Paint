using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSelect : MonoBehaviour
{
    public Transform checkObj;
    
    public float timeDelayed;
    
    public AudioSource audioSource;

    private void Start()
    {
        if (audioSource == null)
            audioSource = GetComponent<AudioSource>();
        
        if ((LevelStatus.D1Status == "yes") && (gameObject.tag == "Drawing1"))
        {
            Instantiate(checkObj, transform.position, checkObj.rotation);
            SceneManager.LoadScene("ImageMenu");
        }
        
        if ((LevelStatus.D2Status == "yes") && (gameObject.tag == "Drawing2"))
        {
            Instantiate(checkObj, transform.position, checkObj.rotation);
            SceneManager.LoadScene("ImageMenu");
        }
        
        if ((LevelStatus.D3Status == "yes") && (gameObject.tag == "Drawing3"))
        {
            Instantiate(checkObj, transform.position, checkObj.rotation);
            SceneManager.LoadScene("ImageMenu");
        }
        
        if ((LevelStatus.D4Status == "yes") && (gameObject.tag == "Drawing4"))
        {
            Instantiate(checkObj, transform.position, checkObj.rotation);
            SceneManager.LoadScene("ImageMenu");
        }
        
        if ((LevelStatus.D5Status == "yes") && (gameObject.tag == "Drawing5"))
        {
            Instantiate(checkObj, transform.position, checkObj.rotation);
            SceneManager.LoadScene("ImageMenu");
        }
        
        if ((LevelStatus.D6Status == "yes") && (gameObject.tag == "Drawing6"))
        {
            Instantiate(checkObj, transform.position, checkObj.rotation);
            SceneManager.LoadScene("ImageMenu");
        }
    }

    private void OnMouseDown()
    {
        StartCoroutine(LoadSceneAfterDelay());
        
        if (audioSource != null && !audioSource.isPlaying)
        {
            audioSource.Play();
        }
    }

    IEnumerator LoadSceneAfterDelay()
    {
        yield return new WaitForSeconds(timeDelayed);
        
        SceneManager.LoadScene(gameObject.tag);
        
        BoxTouchBehavior.PixelCount();
    }
}
