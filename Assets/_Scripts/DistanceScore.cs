using System.Collections;
using UnityEngine;
using TMPro;

public class DistanceScore : MonoBehaviour
{
    public static DistanceScore instance;

    public int distanceScore;
    public TMP_Text scoreText;
    public TMP_Text highScoreText;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        distanceScore = 0;
        highScoreText.text = "High Score: " + PlayerPrefs.GetInt("highScore", 0).ToString() + " Mts";
        StartCoroutine(AddScore());
    }

    private IEnumerator AddScore()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.3f);
            distanceScore += 1;
            scoreText.text = "Score: " + distanceScore.ToString() + " Mts";
        }
    }

    private void OnDestroy()
    {
        if (distanceScore > PlayerPrefs.GetInt("highScore", 0))
        {
            PlayerPrefs.SetInt("highScore", distanceScore);
        }
        PlayerPrefs.SetInt("lastScore", distanceScore);
    }
}
