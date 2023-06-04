using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitSoundScript : MonoBehaviour
{
    public AudioSource leftHitSound;
    public AudioSource rightHitSound;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "LeftHand Controller")
        {
            leftHitSound.Play();

        }
        if (other.gameObject.name == "RightHand Controller")
        {
            rightHitSound.Play();
        }
    }
}