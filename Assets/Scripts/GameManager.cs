using System.Collections;
using UnityEngine;
using UnityEditor.SceneManagement;
using TMPro;
public class GameManager : MonoBehaviour
{
    public static GameManager gm;
    public GameObject startButton;
    public Player player;
    public TextMeshProUGUI gameOverCountdown;
    public TextMeshProUGUI gameScore;
    public float countTimer = 5;
    public int score = 0;

    private void Awake() {
        if (!gm) {
            gm = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        gameOverCountdown.gameObject.SetActive(false);
        Time.timeScale = 0;
    }
    private void Update()
    {
        gameScore.text = score.ToString("0");

        if (player.isDead)
        {
            gameOverCountdown.gameObject.SetActive(true);
            countTimer -= Time.unscaledDeltaTime;
        }
        gameOverCountdown.text = "Restarting in " + countTimer.ToString("0");
        
        if (countTimer < 0)
        {
            RestartGame();
        }
    }
    public void StartGame()
    {
        startButton.SetActive(false);
        Time.timeScale = 1;
    }
    public void GameOver()
    {
        Time.timeScale = 0;
    }
    public void RestartGame()
    {
        score = 0;
        EditorSceneManager.LoadScene(0);
    }

    public void IncreaseScore()
    {
        Debug.Log("score " + score.ToString());
        score += 1;
    }
}