using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Josh Bonovich
//Project 6
//This script allows you to use a Pause Menu
public class MenuControls : MonoBehaviour
{
    private GameObject pauseMenu;
    private bool paused = false;
    private GameManager gm;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
        pauseMenu = transform.GetChild(0).gameObject;
        gm = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Main Menu")==null)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                if (!paused)
                    Pause();
                else
                    UnPause();
            }
        }
    }

    void Pause()
    {
        Time.timeScale = 0f;
        paused = true;
        pauseMenu.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
    }

    void UnPause()
    {
        Time.timeScale = 1f;
        paused = false;
        pauseMenu.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void Resume()
    {
        UnPause();
    }

    public void Restart()
    {
        paused = false;
        gm.RestartLevel();
    }

    public void Exit()
    {
        paused = false;
        gm.ReturnToMenu();
    }
}
