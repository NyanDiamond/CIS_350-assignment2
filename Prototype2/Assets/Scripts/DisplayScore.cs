﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DisplayScore : MonoBehaviour
{

    public Text textbox;
    public int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        textbox.text = "Score: " + score;
    }

    // Update is called once per frame
    void Update()
    {
        textbox.text = "Score: " + score;
    }
}
