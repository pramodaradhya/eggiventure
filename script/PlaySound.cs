using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    public AudioSource Source;
    public List<AudioClip> audioClips = new List<AudioClip>();
    void Start()
    {
        Source = GetComponent<AudioSource>();
    }

    void Update()
    {
        
    }
    public void Play(int sound)
    {
        Source.clip = audioClips[sound];
        Source.Play();
    }
}
