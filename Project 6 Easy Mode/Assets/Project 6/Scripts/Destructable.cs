using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Josh Bonovich
//Project 6 Easy mode
//This script allows for destructable obstacles
public class Destructable : MonoBehaviour, Damageable
{
    [SerializeField] float health;
    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0)
            Destroy();
    }

    void Destroy()
    {
        Destroy(gameObject);
    }
}
