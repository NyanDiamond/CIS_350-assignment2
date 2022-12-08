using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

//Josh Bonovich
//Assignment 9
//This script is used to move the player to a set point

public class MoveTo : MonoBehaviour
{

    public Transform goal;
    // Start is called before the first frame update
    void Start()
    {
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        agent.destination = goal.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
