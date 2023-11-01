using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomAudio : MonoBehaviour
{
    // ---------------------------
    // Variables
    // ---------------------------

    [Header("Random Audio")]
    [SerializeField] AudioClip[] audios;
    AudioSource audioSource;

    // ---------------------------
    // Functions
    // ---------------------------

    void Start()
    {
        // Set Variables
        audioSource = GetComponent<AudioSource>();
    }

    int GetRandomInt(int minInt, int maxInt)
    {
        int randomInt = Random.Range(minInt, maxInt);
        return randomInt;
    }

    public void PlayRandomAudio()
    {
        audioSource.clip = audios[GetRandomInt(0, audios.Length)];
        audioSource.Play();
    }
}
