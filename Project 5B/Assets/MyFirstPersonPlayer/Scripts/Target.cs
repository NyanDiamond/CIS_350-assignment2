using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Josh Bonovich
//Project 5B
//This script holds the health of the targets
public class Target : MonoBehaviour
{
    public float health = 30f;

    public void TakeDamage(float amount)
    {
        health -= amount;
        if(health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
