using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Josh Bonovich
//Prototype 4
//This script controls enemy AI
public class EnemyAI : MonoBehaviour
{

    private Rigidbody rb;
    private GameObject player;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 direction = (player.transform.position - transform.position).normalized;

        rb.AddForce(speed * direction);

        if (transform.position.y < -10)
        {
            Destroy(gameObject);
        }
    }
}
