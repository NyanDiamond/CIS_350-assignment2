using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;

/*
 * Josh Bonovich    
 * Prototype 1
 * Code for the game to have a fail state when you fall
 */
public class LoseOnFall : MonoBehaviour
{
    //public Text textBox;
    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -1)
        {
            //textBox.text = "You Lose!";
            ScoreManager.gameOver = true;
        }
    }
}
