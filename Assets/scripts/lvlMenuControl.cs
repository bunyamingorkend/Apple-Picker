using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lvlMenuControl : MonoBehaviour
{
    AudioSource backMusic;
    private void Start()
    {
        backMusic = GetComponent<AudioSource>();
    }
    public void playBackMusic()
    {
        backMusic.mute = false;
    }
    public void stopBackMusic()
    {
        backMusic.mute = true;
    }

}
