using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*Josh Bonovich
 *Prototype2
 *This script is used to spawn animals
 */
public class SpawnBehavior : MonoBehaviour
{
    public GameObject[] animals;

    private HealthSystem hs;
    // Start is called before the first frame update
    private void Start()
    {
        Time.timeScale = 1f;
        hs = GameObject.FindObjectOfType<HealthSystem>();
        //InvokeRepeating("SpawnRandomPrefab", 2, 1.5f);
        StartCoroutine(SpawnRandom());
    }

    // Update is called once per frame
    /*void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            SpawnRandomPrefab();
        } 
    }
    */
    void SpawnRandomPrefab()
    {
        Instantiate(animals[Random.Range(0, animals.Length)], new Vector3(Random.Range(-14, 14f), 0, 20), Quaternion.Euler(0, 180, 0));
    }

    IEnumerator SpawnRandom()
    {
        yield return new WaitForSeconds(3f);

        while (!hs.gameOver)
        {
            SpawnRandomPrefab();
            yield return new WaitForSeconds(Random.Range(1, 2));
        }

        Time.timeScale = 0f;
    }
}

