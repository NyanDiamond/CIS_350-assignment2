using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DifficultyButton : MonoBehaviour
{
    private Button button;

    private GameManager gm;

    [SerializeField] float spawnrate;
    [SerializeField] GameObject title;
    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.FindObjectOfType<GameManager>();
        button = GetComponent<Button>();
        button.onClick.AddListener(SetDifficulty);
    }

    void SetDifficulty()
    {
        gm.StartGame(spawnrate);
        title.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
