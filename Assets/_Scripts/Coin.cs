using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
    public AudioClip coinSound;
    private Score ScoreText;

    private void Start()
    {
        ScoreText = GameObject.FindGameObjectWithTag("ScoreText").GetComponent<Score>();
    }

    private void Update()
    {
        gameObject.transform.Rotate(0, 1, 0.5f);
    }

    private void OnTriggerEnter(Collider other)
    {
        ScoreText.ScorePlusOne();
        AudioSource.PlayClipAtPoint(coinSound, transform.position);
        Destroy(gameObject);
    }
}
