using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public int scoreInt;
    public TextMeshProUGUI scoreText;

    void Start()
    {
        // Get the score from PlayerPrefs
        scoreInt = PlayerPrefs.GetInt("PlayerScore", 0);
    }

    public bool TryRemoveScore(int scoreToRemove)
    {
        if (scoreInt >= scoreToRemove)
        {
            scoreInt -= scoreToRemove;
            // Save the score to PlayerPrefs
            PlayerPrefs.SetInt("PlayerScore", scoreInt);
            return true;
        }
        else
        {
            return false;
        }
    }

    public void ScorePlusOne()
    {
        scoreInt++;
        // Save the score to PlayerPrefs
        PlayerPrefs.SetInt("PlayerScore", scoreInt);
    }

    private void Update()
    {
        scoreText.text = scoreInt.ToString();
    }
}
