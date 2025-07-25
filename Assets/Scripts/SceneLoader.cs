using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    // Call this function on Start Game button
    public void LoadGameScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    // Optional: Quit button support
    public void QuitGame()
    {
        Application.Quit();
    }
}

