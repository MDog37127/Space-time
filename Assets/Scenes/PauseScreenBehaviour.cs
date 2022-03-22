using UnityEngine;
using UnityEngine.SceneManagement; // SceneManager
public class PauseScreenBehaviour : MainMenuBehaviour
{
    public static bool paused;
    [Tooltip("Reference to the pause menu object to turn on/off")]
    public GameObject pauseMenu;
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    /// <summary>
    /// Will turn our pause menu on or off
    /// </summary>
    /// <param name="isPaused"></param>
    public void SetPauseMenu(bool isPaused)
    {
        paused = isPaused;
        // If the game is paused, timeScale is 0, otherwise 1
        Time.timeScale = (paused) ? 0 : 1;
        pauseMenu.SetActive(paused);
    }
    void Start()
    {
        // Must be reset in Start or else game will be paused upon
        // restart
        SetPauseMenu(false);
    }
    void FixedUpdate()
    {
        // If the game is paused, don't do anything
        if (PauseScreenBehaviour.paused)
        {
            return;
        }
    }
    private void Update()
    {
        // If the game is paused, don't do anything
        if (PauseScreenBehaviour.paused)
        {
            return;
        }
    }
}