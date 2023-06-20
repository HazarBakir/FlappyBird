using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public PlayerMove player;
    public GameObject GameStopMenu;
    private bool isGamePaused = false;

    private void Start()
    {
        Time.timeScale = 1;
    }
    public void Initialize()
    {
        player = new PlayerMove();
    }
    private void Update()
    {
        StopTheGame();
        if (!player.birdAlive)
        {
            ShowGameOverUI();
        }
    }

    public void ShowGameOverUI()
    {
        SceneManager.LoadScene("GameOverScreen");
    }
    public void LoadMainScene()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void LoadGameScene()
    {
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
            }
            else
            {
                Time.timeScale = 0f;
                isGamePaused = true;
                GameStopMenu.SetActive(true);


            }

        }
    }
}
