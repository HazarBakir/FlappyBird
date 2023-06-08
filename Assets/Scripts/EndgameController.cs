using UnityEngine;
using UnityEngine.SceneManagement;

public class EndgameController : MonoBehaviour
{
    public GameObject gameOverUI;

    // Start is called before the first frame update
    void Start()
    {
        ShowGameOverUI();
    }
    public void ShowGameOverUI()
    {
        gameOverUI.SetActive(true);
    }
    public void LoadMainScene()
    {
        SceneManager.LoadScene("MainScene");
    }
}
