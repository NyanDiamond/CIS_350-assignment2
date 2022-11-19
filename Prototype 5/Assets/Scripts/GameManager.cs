using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    [SerializeField] List<GameObject> targets;

    [SerializeField] float spawnRate = 1.0f;

    [SerializeField] TextMeshProUGUI scoreText;

    [SerializeField] TextMeshProUGUI gameOverText;
    private int score;
    public bool isGameActive;
    // Start is called before the first frame update


    public void StartGame(float difficulty)
    {
        isGameActive = true;
        StartCoroutine(SpawnTarget());
        score = 0;
        UpdateScore(0);
        spawnRate = difficulty;
    }

    public void UpdateScore(int value)
    {
        score += value;
        scoreText.text = "Score: " + score;
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);
        isGameActive = false;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    IEnumerator SpawnTarget()
    {
        while(isGameActive)
        {
            yield return new WaitForSeconds(spawnRate);
            int index = Random.Range(0, targets.Count);
            Instantiate(targets[index]);
        }
    }
}
