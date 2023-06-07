using UnityEngine;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    public GameObject mainMenuCanvas;
    public Animator menuAnimator;
    public Button pauseButton;

    private bool hasShownMenu = false;

    void Start()
    {
        // Check if the menu has been shown before
        int hasShownMenuValue = PlayerPrefs.GetInt("hasShownMenu", 0);
        hasShownMenu = (hasShownMenuValue == 1);

        if (!hasShownMenu)
        {
            mainMenuCanvas.SetActive(true);
            Time.timeScale = 0; // Pause the game
            hasShownMenu = true;
            PlayerPrefs.SetInt("hasShownMenu", 1);
        }
        else
        {
            ResumeGame();
        }

        // Add a listener for the pause button
        pauseButton.onClick.AddListener(PauseGame);
    }

    public void ResumeGame()
    {
        mainMenuCanvas.SetActive(false);
        Time.timeScale = 1; // Resume the game
        Time.fixedDeltaTime = 0.02f * Time.timeScale; // Restore the fixed delta time
    }

    void PauseGame()
    {
        mainMenuCanvas.SetActive(true);
        Time.timeScale = 0; // Pause the game
        Time.fixedDeltaTime = 0; // Disable the fixed delta time
    }

    void LateUpdate()
    {
        if (mainMenuCanvas.activeSelf && menuAnimator != null)
        {
            // Update the animator with unscaled delta time to animate UI elements smoothly while game is paused
            menuAnimator.Update(Time.unscaledDeltaTime);
        }
    }

    void OnDestroy()
    {
        PlayerPrefs.Save(); // Save the PlayerPrefs
    }
}
