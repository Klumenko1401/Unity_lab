using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AudioScript : MonoBehaviour
{
    // ��������� ���� ������� ��� ��� � ��������� Unity
    public AudioSource audioSource;

    void OnCollisionEnter(Collision collision)
    {
        audioSource.Play();
    }
}
