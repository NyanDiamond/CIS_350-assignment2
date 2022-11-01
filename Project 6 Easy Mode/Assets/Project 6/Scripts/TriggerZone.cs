using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//Josh Bonovich
//Project 5B
//This script controls the ending trigger

public class TriggerZone : MonoBehaviour
{
    public GameObject winText;
    private bool gameover = false;
    // Start is called before the first frame update

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R) && gameover)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            winText.SetActive(true);
            gameover = true;
            Time.timeScale = 0f;
        }
    }
}
