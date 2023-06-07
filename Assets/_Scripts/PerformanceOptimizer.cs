using UnityEngine;
using UnityEngine.SceneManagement;

public class PerformanceOptimizer : MonoBehaviour
{
    private int targetFrameRate = 60;
    private float threshold = 0.5f;

    private void Awake()
    {
        Application.targetFrameRate = targetFrameRate;
    }

    private void Update()
    {
        float currentTime = Time.realtimeSinceStartup;
        float deltaTime = Time.deltaTime;

        if (deltaTime > threshold)
        {
            // Reduce the quality settings to improve performance
            QualitySettings.DecreaseLevel();
        }
    }

    private void OnApplicationQuit()
    {
        // Reset the quality settings when the game is closed
        QualitySettings.SetQualityLevel(5, true);
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // Reset the quality settings when a new scene is loaded
        QualitySettings.SetQualityLevel(5, true);
    }
}
