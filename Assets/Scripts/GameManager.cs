using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverView;
    public GameObject gameStartView;
    public Text scoreView;
    
    private int _score;

    public int Score
    {
        get => _score;
        set
        {
            _score = value;
            scoreView.text = value.ToString();
        }
    }

   /* private void Init()
    {
        
    }*/

    private void StartGame()
    {
        gameStartView.SetActive(false);
        Time.timeScale = 1;
    }

    private void Start()
    {
        gameStartView.SetActive(true);
        Time.timeScale = 0;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }

    public void GameOver()
    {
        gameOverView.SetActive(true);
        Time.timeScale = 0;
    }
}
