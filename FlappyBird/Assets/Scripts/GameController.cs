using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public PlayerMove player;
    public void Initialize()
    {
        player = new PlayerMove();
    }
    private void Update()
    {
        if (!player.birdAlive)
        {
            ShowGameOverUI();
        }
    }

    // Start is called before the first frame update
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
}
