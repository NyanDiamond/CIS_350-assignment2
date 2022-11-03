using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Josh Bonovich
//Project 6 Easy mode
//This script controls button presses on the main menu
public class MainMenuBehavior : MonoBehaviour
{
    private GameManager gm;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
        gm = GameObject.FindObjectOfType<GameManager>(); 
    }

    public void Showcase()
    {
        gm.LoadLevel("Showcase");
    }
    public void TargetPractice()
    {
        gm.LoadLevel("Target Practice");
    }

    public void Exit()
    {
        Application.Quit();
    }

}
