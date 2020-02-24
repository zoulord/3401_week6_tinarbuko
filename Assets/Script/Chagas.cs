using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Chagas : MonoBehaviour
{
    public Rigidbody2D chagasRigidbody;
    public float flapForce;
    public GameObject gameoverUI;
    public AudioSource clickPlay;
    public AudioSource backgroundPlay;
    public AudioSource gameoverPlay;
    public AudioSource scorePlay;
   

    int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Debug.Log("flap is working");

            //chagasRigidbody.AddForce(Vector2.up * flapForce);

            chagasRigidbody.velocity = Vector2.up * flapForce;
            clickPlay.Play();
        }
    }

    //
   private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "ScoreTag")
        {
            score += 1;
            Debug.Log(score);
            scorePlay.Play();
        }
        else
        {

            gameoverUI.SetActive(true);
            backgroundPlay.Stop();
            gameoverPlay.Play();
            Time.timeScale = 0;
        }


    }


    public void OnRestartButtonPressed ()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("TinarbukoScene");
    }

  
}
