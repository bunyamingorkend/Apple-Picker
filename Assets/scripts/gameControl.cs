using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class gameControl : MonoBehaviour
{
    AudioSource music;
    private void Start()
    {
        music = GetComponent<AudioSource>();
    }
    public void startGameBtn()
    {
        SceneManager.LoadScene("levelScene");
    }
    public void quitGameBtn()
    {
        Application.Quit();
    }
    public void volumeOpen()
    {
        music.mute = false;
    }
    public void volumeclose()
    {
        music.mute = true;
    }
}
