using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Josh Bonovich
//Project 6 Easy mode
//This scriptable object is to hold the data of all target type objects
[CreateAssetMenu(fileName = "Targets")]
public class TargetStats : ScriptableObject
{
    // Start is called before the first frame update
    public int score;
    public int health;
}
