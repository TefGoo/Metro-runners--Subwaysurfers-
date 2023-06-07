using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TMP_Text scoreText;
    public TMP_Text highScoreText;

    private void Start()
    {
        int lastScore = PlayerPrefs.GetInt("lastScore", 0);
        int highScore = PlayerPrefs.GetInt("highScore", 0);

        scoreText.text = "Score: " + lastScore.ToString() + " Mts";

        if (lastScore > highScore)
        {
            highScore = lastScore;
            PlayerPrefs.SetInt("highScore", highScore);
        }

        highScoreText.text = "";

        StartCoroutine(ShowHighScoreDelayed(highScore));
    }

    private System.Collections.IEnumerator ShowHighScoreDelayed(int highScore)
    {
        yield return new WaitForSeconds(1f);
        highScoreText.text = highScore.ToString();
    }
}
