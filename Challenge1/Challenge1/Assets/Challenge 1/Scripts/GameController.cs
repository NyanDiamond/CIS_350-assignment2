using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/*
 * Josh Bonovich    
 * Challenge 1
 * Code to keep track of the score and win/loss states
 */
public class GameController : MonoBehaviour
{

    public static int score;
    public static bool gameOver;

    public Text textBox;
    private bool win;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        gameOver = false;
        win = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (score >= 5)
        {
            win = true;
            gameOver = true;
        }
        if (gameOver == true)
        {
            if (win)
            {
                textBox.text = "You Win!\nPress R to restart";
            }
            else
            {
                textBox.text = "You Lose!\nPress R to restart";
            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
        else
        {
            textBox.text = "Score: " + score;
        }
    }
}
