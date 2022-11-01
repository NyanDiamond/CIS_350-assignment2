using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Josh Bonovich
//Project 6
//This script is a scene managing singleton
public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private static string current;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void LoadLevel(string levelName)
    {
        AsyncOperation ao = SceneManager.LoadSceneAsync(levelName, LoadSceneMode.Additive);
        if (ao == null)
        {
            Debug.LogError("[Gamemanager] Unable to load level " + levelName);
            return;
        }
        else
        {
            current = levelName;
           
        }
    }

    public void ReturnToMenu()
    {
        UnLoadLevel(current);

    }
    public void RestartLevel()
    {
        LoadLevel(current);
    }

    private void UnLoadLevel(string levelName)
    {
        AsyncOperation ao = SceneManager.UnloadSceneAsync(levelName);
        if (ao == null)
        {
            Debug.LogError("[Gamemanager] Unable to unload level " + levelName);
            return;
        }
    }



}

