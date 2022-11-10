using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//Josh Bonovich
//Prototype 4
//This script controls the spawning mechanics
public class SpawnManager : MonoBehaviour
{

    public GameObject enemy;
    public GameObject powerUp;
    public Text waveCounter;
    public GameObject gameOverScreens;
    public Text gameOverText;
    public bool win = false;
    public bool gameOver;
    private float spawnRange = 9;

    public int enemies;
    private int waveCount = 1;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
        SpawnEnemyWave(waveCount);
        SpawnPowerUp(1);
    }

    private void SpawnEnemyWave(int enemiesToSpawn)
    {
        waveCounter.text = "Wave: " + waveCount;
        for (int i = 0; i<enemiesToSpawn; i++)
            Instantiate(enemy, generateSpawnPos(), enemy.transform.rotation);
    }

    private void SpawnPowerUp(int powerUps)
    {
        for (int i = 0; i < powerUps; i++)
            Instantiate(powerUp, generateSpawnPos(), powerUp.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver == true)
        {
            if(Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
            if(Input.GetKeyDown(KeyCode.Space))
            {
                Application.Quit();
                Debug.Log("Quitting");
            }
        }
        else
        {
            enemies = GameObject.FindGameObjectsWithTag("Enemy").Length;
            if (enemies == 0)
            {
                waveCount++;
                if (waveCount > 10)
                { 
                    win = true;
                    GameOver();
                    return;
                }
                SpawnEnemyWave(waveCount);
                SpawnPowerUp(Mathf.CeilToInt(waveCount/5));
            }
        }
    }

    public void GameOver()
    {
        gameOver = true;
        Time.timeScale = 0f;
        if(win)
        {
            gameOverText.text = "You Win!";
        }
        else
        {
            gameOverText.text = "You Lose";
        }
        gameOverScreens.SetActive(true);
    }

    Vector3 generateSpawnPos()
    {
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);
        return new Vector3(spawnPosX, 0, spawnPosZ);
    }
}
