using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Josh Bonovich
//Project 6 Easy mode
//This script allows for civilians to play a special sound when dying
public class CivilianBehavior : Target
{
    //public AudioClip clip;
    // Start is called before the first frame update
    protected override void Die()
    {
        AudioSource.PlayClipAtPoint(Resources.Load<AudioClip>("Wrong"),FindObjectOfType<Camera>().transform.position);
        base.Die();
    }
}
