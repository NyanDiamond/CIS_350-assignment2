using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Josh Bonovich
//Prototype 3
//This controls all of the player's movement and behavior
public class PlayerController : MonoBehaviour
{

    private Rigidbody rb;
    private Animator playerAnimator;
    public float jumpForce;
    public ForceMode jumpForceMode;
    public float gravityModifier;
    public ParticleSystem deathSmoke;
    public ParticleSystem runningDirt;
    public AudioClip jumpSound;
    public AudioClip crashSound;

    public bool isOnGround = true;
    public bool gameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        playerAnimator = GetComponent<Animator>();
        playerAnimator.SetFloat("Speed_f", 1.0f);
        playerAnimator.SetInteger("DeathType_int", 1);
        Physics.gravity = new Vector2(0, -9.81f);
        Physics.gravity *= gravityModifier;
        jumpForceMode = ForceMode.Impulse;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround && !gameOver)
        {
            rb.AddForce(jumpForce * Vector3.up, jumpForceMode);
            isOnGround = false;
            playerAnimator.SetTrigger("Jump_trig");
            runningDirt.Stop();
            AudioSource.PlayClipAtPoint(jumpSound, GameObject.Find("Main Camera").transform.position);
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        
        if (!isOnGround)
        {
            if (collision.gameObject.CompareTag("Ground"))
            {
                isOnGround = true;
                runningDirt.Play();
            }
        }
        if(collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("GameOver");
            AudioSource.PlayClipAtPoint(crashSound, GameObject.Find("Main Camera").transform.position);
            gameOver = true;
            deathSmoke.Play();
            runningDirt.Stop();
            playerAnimator.SetBool("Death_b", true);
        }
            
        
    }
}
