using UnityEngine;

public class GameConfigManager : MonoBehaviour
{
    public GameConfig config;

    void Start()
    {
        Debug.Log("Speed: " + config.playerSpeed);
        Debug.Log("MaxScore: " + config.maxScore);
        Debug.Log("Health: " + config.playerHealth);
    }
}