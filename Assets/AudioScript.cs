using UnityEngine;
using UnityEngine.Events;

public class AudioScript : MonoBehaviour
{
    public AudioSource audioSource;

    public UnityEvent onCollisionEnter;
    public UnityEvent onCollisionExit;

    private bool isColliding = false;

    void Start()
    {
        onCollisionEnter.AddListener(PlaySound);
    }

    void Update()
    {
        if (isColliding)
        {
            onCollisionEnter.Invoke();
        }
        else
        {
            onCollisionExit.Invoke();
        }
    }

    void PlaySound()
    {
        audioSource.Play();
    }

    void StopSound()
    {
        audioSource.Stop();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        isColliding = true;
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        isColliding = false;
    }
}
