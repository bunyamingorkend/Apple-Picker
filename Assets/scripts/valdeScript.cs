using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class valdeScript : MonoBehaviour
{
    public Text scoreText;

    public GameObject apple;
    public GameObject valdeApple1, valdeApple2, valdeApple3, valdeApple4, valdeApple5;

    public float horizontalMove;
    public float speed;
    public int score = 0;

    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();

    }
    private void Update()
    {
      //  horizontalMove = Input.GetAxis("Horizontal");
        rb.velocity = new Vector3(horizontalMove * speed * Time.deltaTime * 250, 0, 0);
    }
    public void goRigt()
    {
        horizontalMove = 1;
    }
    public void goLeft()
    {
        horizontalMove = -1;
    }
   public void stopMove()
    {
        horizontalMove = 0;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="Player")
        {
            score += 10;
            scoreText.text = "Score= " + score;
            other.transform.position = new Vector3(Random.Range(-5, 7), 8, -9.56f);
            switch(score){
                case  20 :
                        valdeApple1.SetActive(true);
                    break;
                case 40:
                    valdeApple2.SetActive(true);
                    break;
                case 60:
                    valdeApple3.SetActive(true);
                    break;
                case 80:
                    valdeApple4.SetActive(true);
                    break;
                case 100:
                    valdeApple5.SetActive(true);
                    break;
            }
        }
        
    }
}
