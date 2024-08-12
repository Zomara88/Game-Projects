using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float delaytime = 0.5f;
    [SerializeField] ParticleSystem finishEffect;
    [SerializeField] AudioClip crashSFX;
    bool firstTime = false;
    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Ground" && firstTime == false)
        {
            FindAnyObjectByType<PlayerController>().DisableControls();
            finishEffect.Play();
            GetComponent<AudioSource>().PlayOneShot(crashSFX);
            firstTime = true;
            Invoke("ReloadScene", delaytime);
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
