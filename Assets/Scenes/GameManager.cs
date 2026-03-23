using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            Debug.Log("GameManager tồn tại");
        }
        else
        {
            Debug.Log("GameManager bị trùng → xoá");
            Destroy(gameObject);
        }
    }
}