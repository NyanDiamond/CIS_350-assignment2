using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Josh Bonovich
//Project 6
//controls the game mechanics
public class GameControllerBehavior : MonoBehaviour
{
    [SerializeField] Text scoreText, targetsLeft, accuracyText;
    private int score, maxTargets = 40, targets;
    private float shotsTaken = 0, shotsHit = 0;

    // Start is called before the first frame update

    public void Start()
    {
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.Locked;
        targets = maxTargets;
        targetsLeft.text = "Targets Left: " + maxTargets;
    }
    public void addScore(int value)
    {
        score += value;
        scoreText.text = "Score: " + score;
        
    }

    public void shotTaken(bool hit)
    {
        shotsTaken += 1;
        if(hit)
        {
            shotsHit += 1;
        }
        accuracyText.text = "Accuracy: " + Mathf.RoundToInt(100 * (shotsHit / shotsTaken)) + "%";
    }

    public void targetLaunched()
    {
        targets--;
    }
}
