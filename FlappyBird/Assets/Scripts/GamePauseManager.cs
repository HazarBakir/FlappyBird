using UnityEngine;

public class GamePauseManager
{
    private bool isGamePaused = false;

    public void PauseGame()
    {
        Time.timeScale = 0f;
        isGamePaused = true;
    }

    public void ResumeGame()
    {
        Time.timeScale = 1f;
        isGamePaused = false;
    }

    public bool IsGamePaused()
    {
        return isGamePaused;
    }
}
