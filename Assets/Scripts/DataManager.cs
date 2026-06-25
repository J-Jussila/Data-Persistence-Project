using UnityEngine;

public class DataManager : MonoBehaviour
{
    public static DataManager Instance;

    public string playerName;

    public string bestPlayerName;
    public int bestScore;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            LoadHighScore();
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SaveHighScore()
    {
        PlayerPrefs.SetString("BestPlayer", bestPlayerName);
        PlayerPrefs.SetInt("BestScore", bestScore);
        PlayerPrefs.Save();
    }

    public void LoadHighScore()
    {
        bestPlayerName = PlayerPrefs.GetString("BestPlayer", "");
        bestScore = PlayerPrefs.GetInt("BestScore", 0);
    }
}