using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Josh Bonovich
//Prototype 4
//This script will control the player
public class PlayerController : MonoBehaviour
{
    private float forwardInput;
    private Rigidbody rb;
    public float speed;
    public bool hasPowerUp;
    public float powerUpStrength = 15f;
    private GameObject focalPoint;
    public GameObject powerUpIndicator;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        focalPoint = GameObject.FindGameObjectWithTag("FocalPoint");
    }

    // Update is called once per frame
    void Update()
    {
        forwardInput = Input.GetAxis("Vertical");

        powerUpIndicator.transform.position = transform.position + new Vector3(0, -0.5f, 0);

        if(transform.position.y < -10)
        {
            GameObject.FindObjectOfType<SpawnManager>().GameOver();
        }

    }

    private void FixedUpdate()
    {
        if (forwardInput != 0)
            rb.AddForce(focalPoint.transform.forward * speed * forwardInput);
        else
            rb.AddForce(rb.velocity * -1f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("PowerUp"))
        {
            hasPowerUp = true;
            Destroy(other.gameObject);
            StopAllCoroutines();
            StartCoroutine(PowerUpCountdown());
            powerUpIndicator.SetActive(true);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Enemy") && hasPowerUp)
        {
            Rigidbody enemyRb = collision.gameObject.GetComponent<Rigidbody>();
            enemyRb.AddForce((collision.gameObject.transform.position - transform.position).normalized 
                * powerUpStrength, ForceMode.Impulse);
        }
    }

    IEnumerator PowerUpCountdown()
    {
        yield return new WaitForSeconds(7f);
        hasPowerUp = false;
        powerUpIndicator.SetActive(false);
    }

}
