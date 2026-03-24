using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int score = 0;

    public void SaveScore()
    {
        int highScore = PlayerPrefs.GetInt("HighScore", 0);

        if (score > highScore)
        {
            PlayerPrefs.SetInt("HighScore", score);
            PlayerPrefs.Save();
            Debug.Log("Đã lưu HighScore: " + score);
        }
    }

    public void LoadScore()
    {
        int highScore = PlayerPrefs.GetInt("HighScore", 0);
        Debug.Log("HighScore hiện tại: " + highScore);
    }
}