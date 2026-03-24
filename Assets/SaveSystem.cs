using UnityEngine;
using System.IO;

public class SaveSystem : MonoBehaviour
{
    string path;

    void Start()
    {
        path = Application.persistentDataPath + "/player.json";

        // TEST
        SaveData();
        LoadData();
    }

    public void SaveData()
    {
        PlayerData data = new PlayerData();
        data.playerName = "Minh";
        data.level = 5;
        data.score = 300;

        string json = JsonUtility.ToJson(data, true);

        File.WriteAllText(path, json);

        Debug.Log("Đã lưu file tại: " + path);
    }

    public void LoadData()
    {
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);

            PlayerData data = JsonUtility.FromJson<PlayerData>(json);

            Debug.Log("Tên: " + data.playerName);
            Debug.Log("Level: " + data.level);
            Debug.Log("Score: " + data.score);
        }
        else
        {
            Debug.Log("Chưa có file save!");
        }
    }
}