using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Josh Bonovich
//Prototype 3
//Manages spawning of obstacles
public class SpawnManager : MonoBehaviour
{

    public GameObject obstaclePrefab;
    private PlayerController playerControllerScript;
    private Vector3 spawnPoint = new Vector3(20f,0,0);
    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.FindObjectOfType<PlayerController>();
        StartCoroutine(Spawning());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacle()
    {
        Instantiate(obstaclePrefab, spawnPoint, obstaclePrefab.transform.rotation);
    }

    IEnumerator Spawning()
    {
        yield return new WaitForSeconds(2f);
        while (!playerControllerScript.gameOver)
        {
            SpawnObstacle();
            yield return new WaitForSeconds(2f);
        }
    }
}
