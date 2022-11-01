using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Josh Bonovich
//Project 5B/6
//This script holds the health of the targets
public class Target : MonoBehaviour
{
    public TargetStats ts;
    private GameControllerBehavior gc;
    private float health;

    private void Start()
    {
        health = ts.health;
        gc = GameObject.FindObjectOfType<GameControllerBehavior>();
    }

    public void TakeDamage(float amount)
    {
        health -= amount;
        if(health <= 0)
        {
            Die();
            return;
        }
        gc.addScore(10);
    }

    protected virtual void Die()
    {
        gc.addScore(ts.score);
        Destroy(gameObject);
    }
}
