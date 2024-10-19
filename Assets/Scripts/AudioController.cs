using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public AudioClip backgroundMusic;  
    private AudioSource audioSource;

    private static AudioController instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);

            audioSource = gameObject.AddComponent<AudioSource>();
            audioSource.clip = backgroundMusic;
            audioSource.loop = true;
            audioSource.playOnAwake = false;

            audioSource.volume = 0.33f;

            audioSource.Play();
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }
}
