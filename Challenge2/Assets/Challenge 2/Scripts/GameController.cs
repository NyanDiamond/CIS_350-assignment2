using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameController : MonoBehaviour
{
    // Start is called before the first frame update

    public static int score;

    public Text scoreText;
    public Text gameOverText;
    private bool win = false;
    void Start()
    {
        score = 0;
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + score;
        if (score >= 5)
        {
            win = true;
            HealthSystem.gameOver = true;
        }

        if (HealthSystem.gameOver)
        {
            
            if(win)
            {
                gameOverText.text = "GameOver\nYou Won!\nPress R to Restart";
            }
            else
            {
                gameOverText.text = "GameOver\nYou Lost\nPress R to Restart";
            }
            Time.timeScale = 0f;
        }
    }
}
