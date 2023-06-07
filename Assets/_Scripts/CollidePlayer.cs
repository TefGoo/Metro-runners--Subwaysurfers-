using UnityEngine.SceneManagement;
using UnityEngine;

public class CollidePlayer : MonoBehaviour
{
    public int score;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            // Player lost the game
            PlayerPrefs.SetInt("Score", score);
            SceneManager.LoadScene("GameOver");
        }
    }
}
