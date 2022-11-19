using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Josh Bonovich
//Prototype 5
//This script controls the target
public class Target : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] float minSpeed = 12;
    [SerializeField] float maxSpeed = 16;
    [SerializeField] float maxTorque = 10;
    [SerializeField] float xRange = 4;
    [SerializeField] float ySpawnPos = -6;
    [SerializeField] int pointVal;
    [SerializeField] ParticleSystem ps;

    private GameManager gm;
    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.FindObjectOfType<GameManager>();
        transform.position = RandomSpawnPos();
        rb = GetComponent<Rigidbody>();
        rb.AddForce(RandomForce(), ForceMode.Impulse);
        rb.AddTorque(RandomTorque(), ForceMode.Impulse);
        
    }

    Vector3 RandomForce()
    {
        return Vector3.up * Random.Range(minSpeed, maxSpeed);
    }

    Vector3 RandomTorque()
    {
        return new Vector3(Random.Range(-maxTorque, maxTorque), Random.Range(-maxTorque, maxTorque),
            Random.Range(-maxTorque, maxTorque));
    }

    Vector3 RandomSpawnPos()
    {
        return new Vector3(Random.Range(-xRange, xRange), ySpawnPos);
    }
    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        if (gm.isGameActive)
        {
            Instantiate(ps, transform.position, ps.transform.rotation);
            gm.UpdateScore(pointVal);
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Sensor"))
        {
            if(!gameObject.CompareTag("Bad"))
            {
                gm.GameOver();
            }

            Destroy(gameObject);
        }
    }
}
