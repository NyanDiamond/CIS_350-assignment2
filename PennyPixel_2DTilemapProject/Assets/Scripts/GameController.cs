using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//Josh Bonovich
//Assignment 5 Prototype 2D
//edited this script to keep track of win/loss conditions as well as use UI elements
public class GameController : MonoBehaviour
{
    public GameObject gameOver;
    public Text gameOverText;
    public Text scoreText;
    public GameObject player;

    private int score=0;
    private bool go = false;


    private void Start()
    {
        Time.timeScale = 1;
        scoreText.text = "Score: 0";
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.R) && go)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if(player.transform.position.y < -5)
        {
            Lose();
        }
    }

    public void Score(int value)
    {
        score += value;
        scoreText.text = "Score: " + score;
    }

    public void Win()
    {
        gameOverText.text = "You Win\nYour final score is " + score + "\nPress R to Restart";
        gameOver.SetActive(true);
        go = true;
        Time.timeScale = 0;
    }

    public void Lose()
    {
        gameOverText.text = "You Lose\nYour final score is " + score + "\nPress R to Restart";
        gameOver.SetActive(true);
        go = true;
        Time.timeScale = 0;
    }
}
