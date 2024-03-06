using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AudioScript : MonoBehaviour
{
    // Призначте аудіо джерело для кулі в інспекторі Unity
    public AudioSource audioSource;

    void OnCollisionEnter(Collision collision)
    {
        audioSource.Play();
    }
}
