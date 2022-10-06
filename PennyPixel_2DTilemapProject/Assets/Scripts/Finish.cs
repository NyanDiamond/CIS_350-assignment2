using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Josh Bonovich
//Prototype 2D
//just checks if player reaches the end
public class Finish : MonoBehaviour
{
    private GameController gc;

    private void Start()
    {
        gc = GameObject.FindObjectOfType<GameController>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            gc.Win();
        }
    }
}
