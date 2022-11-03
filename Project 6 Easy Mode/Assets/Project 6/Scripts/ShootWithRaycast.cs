using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Josh Bonovich
//Project 5B
//This script is to shoot
public class ShootWithRaycast : MonoBehaviour
{
    public float damage = 1f;
    public float hitForce = 10f;
    public float range = 100f;
    public LayerMask layer;
    private GameControllerBehavior gc;
    private Camera cam;

    private ParticleSystem muzzleFlash;

    private void Awake()
    {
        gc = FindObjectOfType<GameControllerBehavior>();
        cam = transform.parent.GetComponent<Camera>();
        muzzleFlash = transform.Find("Muzzle Flash").GetComponent<ParticleSystem>();
    }

    private void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
            muzzleFlash.Play();
        }
    }

    void Shoot()
    {
        bool connected = false;
        RaycastHit hitInfo;
        if(Physics.Raycast(cam.transform.position, cam.transform.forward, out hitInfo, range, layer))
        {
            connected = true;
            GameObject hit = hitInfo.transform.gameObject;
            //Debug.Log(hit.name);

            Damageable target = hit.GetComponent<Damageable>();
            if(target!=null)
            {
                target.TakeDamage(damage);
            }

            //if(hitInfo.rigidbody!= null)
            //{
            //    hitInfo.rigidbody.AddForce(cam.transform.TransformDirection(Vector3.forward) * hitForce, ForceMode.Impulse);
            //}
        }
        gc.shotTaken(connected);
        
    }
}
