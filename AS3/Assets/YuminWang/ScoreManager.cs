using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public GameObject winPanel;
    private int score = 0;

    public void AddScore(int value)
    {
        score += value;
        scoreText.text = "Score: " + score + " / 10";

        if (score >= 10)
        {
            winPanel.SetActive(true);
        }
    }
}
