using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//Josh Bonovich
//Prototype 3
//Manages UI in game
public class UIManager : MonoBehaviour
{
    public int score = 0;
    public Text scoreText;

    public PlayerController playerControllerScript;

    public bool won = false;

    private void Start()
    {
        
        
        if(scoreText == null)
        {
            scoreText = FindObjectOfType<Text>();
        }
        if(playerControllerScript == null)
        {
            playerControllerScript = GameObject.FindObjectOfType<PlayerController>();
        }

        scoreText.text = "Score: 0";
        
    }

    private void Update()
    {
        if (!playerControllerScript.gameOver)
        {
            scoreText.text = "Score: " + score;
        }

        if(playerControllerScript.gameOver && !won)
        {
            scoreText.text = "You Lose!\nPress R to Try Again!";
        }

        if(score >= 10)
        {
            won = true;
            playerControllerScript.gameOver = true;
        }

        if (playerControllerScript.gameOver && won)
        {
            scoreText.text = "You Win!\nPress R to Try Again!";
        }

        if (playerControllerScript.gameOver && Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }


    }
}
