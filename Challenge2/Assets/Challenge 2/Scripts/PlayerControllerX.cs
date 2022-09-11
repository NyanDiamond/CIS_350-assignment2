using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Josh Bonovich
//Challenge2
//Control the player shooting the dog
public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private bool canShoot = true;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && canShoot)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            canShoot = false;
            StartCoroutine(Delay());
        }
    }

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(1f);
        canShoot = true;
    }
}
