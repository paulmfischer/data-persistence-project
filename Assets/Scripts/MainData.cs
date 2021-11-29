using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class MainData : MonoBehaviour
{
    public static MainData Instance;

    public string UserName;

    public string HighScoreUserName;
    public int HighScore;

    // Start is called before the first frame update
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void SaveData(int highScore)
    {
        GameData data = new GameData
        {
            UserName = UserName,
            HighScore = highScore
        };
        File.WriteAllText(getSaveLocation(), JsonUtility.ToJson(data));
    }

    public void LoadData()
    {
        if (File.Exists(getSaveLocation()))
        {
            string json = File.ReadAllText(getSaveLocation());
            GameData data = JsonUtility.FromJson<GameData>(json);
            HighScoreUserName = data.UserName;
            HighScore = data.HighScore;
        }
    }

    private string getSaveLocation()
    {
        return Application.persistentDataPath + "/gamedata.json";
    }

    [Serializable]
    class GameData
    {
        public string UserName;
        public int HighScore;
    }
}
