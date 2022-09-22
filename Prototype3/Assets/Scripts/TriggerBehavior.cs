using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Josh Bonovich
//Prototype 3
//Manages scoring after jumping over an obstacle where tthe trugger is
public class TriggerBehavior : MonoBehaviour
{
    private UIManager uIManager;
    private bool triggered = false;
    // Start is called before the first frame update
    void Start()
    {
        uIManager = GameObject.FindObjectOfType<UIManager>();
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !triggered)
        {
            triggered = true;
            uIManager.score++;
        }
    }
}
