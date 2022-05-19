using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Bird_Controller : MonoBehaviour
{
    public bool gamestart;
    public float jumpForce;
    public Rigidbody2D rb;
    private int score;
    public Text scoreText;
    public GameObject GameOverPanel;
    void Start()
    {
        Time.timeScale = 0;
    }


    void Update()
    {
        if (gamestart)      
        {
            rb.simulated = true;
            if (Input.GetMouseButtonDown(0))
            {
                rb.velocity = Vector2.up * jumpForce;
            }
        }
        else
        {
            rb.simulated = false;
        }
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Score"))
        {
            score++;
            scoreText.text = score.ToString();
        }
        if (collision.gameObject.CompareTag("Death"))
        {
            Time.timeScale = 0;
            GameOverPanel.SetActive(true);
        }
        if (collision.gameObject.CompareTag("Base"))
        {
            Time.timeScale = 0;
            GameOverPanel.SetActive(true);
        }
    }
    
    public void Restart(int anime)
    {
        SceneManager.LoadScene(anime);
    }
}

