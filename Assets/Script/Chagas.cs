using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Chagas : MonoBehaviour
{
    public Rigidbody2D chagasRigidbody;
    public float flapForce;
    public GameObject gameoverUI;
    public AudioSource buttonAudioSource;

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
        }
    }

    //
   private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "ScoreTag")
        {
            score += 1;
            Debug.Log(score);
        }
        else
        {

            gameoverUI.SetActive(true);
            Time.timeScale = 0;
        }


    }


    public void OnRestartButtonPressed ()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("SampleScene");
    }

    public void PlaySound()
    {
        if (buttonAudioSource.isPlaying)
        {
            buttonAudioSource.Stop();
        }
        else
        {
            buttonAudioSource.Play();
        }
    }
}
