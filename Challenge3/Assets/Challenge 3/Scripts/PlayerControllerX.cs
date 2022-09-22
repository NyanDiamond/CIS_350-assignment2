using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Josh Bonovich
//Challenge 3
//This script is to control the player's actions
public class PlayerControllerX : MonoBehaviour
{
    public bool gameOver;
    public float maxSpeed = 10f;
    public float floatForce;
    private float gravityModifier = 1.5f;
    private Rigidbody playerRb;
    private UIManager ui;

    private bool bounced = false;

    public ParticleSystem explosionParticle;
    public ParticleSystem fireworksParticle;

    private AudioSource playerAudio;
    public AudioClip bounce;
    public AudioClip moneySound;
    public AudioClip explodeSound;


    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity = new Vector2(0, -9.8f);
        Physics.gravity *= gravityModifier;
        playerAudio = GetComponent<AudioSource>();
        ui = GameObject.FindObjectOfType<UIManager>();
        // Apply a small upward force at the start of the game
        playerRb.AddForce(Vector3.up * 5, ForceMode.Impulse);

    }

    // Update is called once per frame
    void Update()
    {
        // While space is pressed and player is low enough, float up
        if (Input.GetKey(KeyCode.Space) && !gameOver)
        {
            playerRb.AddForce(Vector3.up * floatForce, ForceMode.Force);
            playerRb.velocity = Vector3.ClampMagnitude(playerRb.velocity, maxSpeed);
        }

        if(transform.position.y < 1 && !bounced)
        {
            playerRb.velocity = -playerRb.velocity;
            playerAudio.PlayOneShot(bounce, 1.0f);
            bounced = true;
        }
        if(transform.position.y > 1)
        {
            bounced = false;
        }

        if(transform.position.y >= 14.44f)
        {
            playerRb.velocity = Vector3.zero;
        }
        transform.position= new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, 0, 14.44f), 0);

        if(gameOver)
        {
            playerRb.constraints = RigidbodyConstraints.FreezeAll;
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        // if player collides with bomb, explode and set gameOver to true
        if (other.gameObject.CompareTag("Bomb"))
        {
            explosionParticle.Play();
            playerAudio.PlayOneShot(explodeSound, 1.0f);
            gameOver = true;
            Debug.Log("Game Over!");
            Destroy(other.gameObject);
            GetComponent<MeshRenderer>().enabled = false;
        } 

        // if player collides with money, fireworks
        else if (other.gameObject.CompareTag("Money"))
        {
            fireworksParticle.Play();
            ui.score++;
            playerAudio.PlayOneShot(moneySound, 1.0f);
            Destroy(other.gameObject);

        }

    }

}
