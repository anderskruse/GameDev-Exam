using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UpdateScore : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    int score;

    void Start()
    {
        
    }


    void Update()
    {
        
    }

    public void incrementScore()
    {
        score++;
        updateScore();
    }

    public void incrementScore(int amount)
    {
        score += amount;
        updateScore();
    }

    void updateScore()
    {
        scoreText.text = "Score: " + score;
    }
}
