using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public int score = 0;
    public Text scoreText;

    void Awake()
    {
        if (Instance == null) Instance = this;
    }

    public void AddScore()
    {
        score++;
        if (scoreText != null) scoreText.text = score.ToString();
    }

    public void GameOver()
    {
        Debug.Log("Game Over! Restarting...");
    }
}
