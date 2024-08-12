using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustTrail : MonoBehaviour
{
    [SerializeField] ParticleSystem snowEffect;
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Ground")
        {
            snowEffect.Play();
        }
    }

    private void OnCollisionExit2D(Collision2D other) {
        snowEffect.Stop();
    }

}
