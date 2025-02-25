using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public CanvasGroup OptionPanel;

    public void PlayGame()
    {
        // Load the next scene (useful for loading the gameplay scene)
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

        public void Retry()
    {
        // Load the next scene (useful for loading the gameplay scene)
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void Option()
    {
        // Make sure OptionPanel is not null before trying to modify its properties
        if (OptionPanel != null)
        {
            OptionPanel.alpha = 1; // Make the option panel visible
            OptionPanel.blocksRaycasts = true; // Enable interaction
            OptionPanel.interactable = true; // Allow user interaction
        }
        else
        {
            Debug.LogWarning("OptionPanel is not assigned!");
        }
    }

    public void Back()
    {
        // Check if OptionPanel is null and hide it
        if (OptionPanel != null)
        {
            OptionPanel.alpha = 0; // Make the option panel invisible
            OptionPanel.blocksRaycasts = false; // Disable interaction
            OptionPanel.interactable = false; // Disable user interaction
        }
        else
        {
            Debug.LogWarning("OptionPanel is not assigned!");
        }
    }

    public void QuitGame()
    {
        // Quit the application
        Application.Quit();

        #if UNITY_EDITOR
        Debug.Log("Game Closed"); // Debug log for editor
        #endif
    }
}
