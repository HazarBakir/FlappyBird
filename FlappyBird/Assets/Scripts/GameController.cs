using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;


public class GameController : MonoBehaviour
{
    public PlayerMove player;
    public MusicVolumeSetter music;
    public GameObject GameStopMenu;
    private bool isGamePaused = false;
    public GameObject resumebutton;
    public GameObject pausebutton;

    public void Initialize()
    {
        player = new PlayerMove();
        music = new MusicVolumeSetter();
    }
    private void Update()
    {
        StopTheGame();
        if (!player.birdAlive)
        {
            music.NoMusic();
            StartCoroutine(GameOverDelay());
        }
    }

    private IEnumerator GameOverDelay()
    {
        yield return new WaitForSeconds(2f); // Wait for 2 seconds

        ShowGameOverUI(); // Transition to the game over UI or another scene
    }

    public void ShowGameOverUI()
    {
        ResumeGame();
        SceneManager.LoadScene("GameOverScreen");
    }
    public void LoadMainScene()
    {
        ResumeGame();
        SceneManager.LoadScene("MainMenu");
    }
    public void LoadGameScene()
    {
        ResumeGame();
        SceneManager.LoadScene("FlappyBirdScene");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    void StopTheGame()
    {
        if (Input.GetKeyDown(KeyCode.P) || Input.GetKeyDown(KeyCode.Escape))
        {
            if (isGamePaused)
            {
                Time.timeScale = 1f;
                isGamePaused = false;
                GameStopMenu.SetActive(false);
                resumebutton.SetActive(true);
                pausebutton.SetActive(false);
            }
            else
            {
                Time.timeScale = 0f;
                isGamePaused = true;
                GameStopMenu.SetActive(true);
                resumebutton.SetActive(false);
                pausebutton.SetActive(true);
            }

        }
    }
    public void ResumeGame()
    {
        Time.timeScale = 1f;
        isGamePaused = false;
    }
}
