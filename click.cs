using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class click : MonoBehaviour
{

    public Text scoreText;
    public int score;
    void Start()
    {
    }


    void Update()
    {
        scoreText.text = "Score: " + score;
        if (Input.GetMouseButtonDown(0))
        {
            score++;
        }
    }
}