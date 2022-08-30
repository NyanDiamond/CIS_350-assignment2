using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ScoreManager : MonoBehaviour
{

    public static bool gameOver = false;
    public static bool won = false;
    public static int score = 0;

    public Text textBox;

    private void Start()
    {
        gameOver = false;
        won = false;
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameOver)
        {
            textBox.text = "Score: " + score;
        }

        if (score>=4)
        {
            won = true;
            gameOver = true;
        }

        if(gameOver)
        {
            if (won)
                textBox.text = "You Win!\nPress R to Try Again";
            else
                textBox.text = "You Lose!\nPress R to Try Again";
            if (Input.GetKeyDown(KeyCode.R))
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
