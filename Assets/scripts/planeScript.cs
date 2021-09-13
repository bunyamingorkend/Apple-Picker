using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class planeScript : MonoBehaviour
{
    public GameObject heart1,heart2,heart3;
    public GameObject apple;
    public GameObject gameOverPlane;
    public Text gameOverScore;
    int life = 3;
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="Player")
        {
            life--;
            other.transform.position = new Vector3(Random.Range(-5, 7), 8, -9.56f);
            if (life==2)
            {
                heart3.SetActive(false);
            }
            else if (life == 1)
            {
                heart2.SetActive(false);
            }
            else if (life == 0)
            {
                heart1.SetActive(false);
            }
            if (life==0)
            {
                gameOverImage();
                Time.timeScale = 0;
            }

        }
    }
    public void gameOverImage()
    {
        gameOverPlane.SetActive(true);
    }
    public void pauseGameBtn()
    {
        bool pauseeGame = false;
        if (pauseeGame==false)
        {
            Time.timeScale = 0;
            pauseeGame = true;
        }
        if (pauseeGame == true)
        {
            Time.timeScale = 1;
            pauseeGame = false;

        }
    }
    
    public void reloadGame()
    {
        SceneManager.LoadScene("lvl1Scene");
        Time.timeScale = 1;
    }
    public void levelsScene()
    {
        SceneManager.LoadScene("levelScene");
    }
}
