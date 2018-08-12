using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour {
    public AudioClip[] audioClip;
    private AudioSource audioSource;
	// Use this for initialization
	void Awake () {
        DontDestroyOnLoad(gameObject);
	}
	void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    void OnLevelWasLoaded(int level)
    {
        AudioClip thisLevelMusic = audioClip[level];
        if (thisLevelMusic) //sprawdza czy jest jakas wartosc w arrayu
        {
            audioSource.clip = thisLevelMusic;
            audioSource.loop = true;
            audioSource.Play();
             
        }
        else
        {
            audioSource.Stop();
        }

    }

}
