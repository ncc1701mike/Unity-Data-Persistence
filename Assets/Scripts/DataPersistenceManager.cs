using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataPersistenceManager : MonoBehaviour
{
    const string playerNameKey = "PlayerName";
    const string scoreKey = "Score";

    public static void SaveData(string playerName, int score)
    {
        PlayerPrefs.SetString(playerNameKey, playerName);
        PlayerPrefs.SetInt(scoreKey, score);
        PlayerPrefs.Save();
    }

     public static string LoadPlayerName()
    {
        return PlayerPrefs.GetString(playerNameKey, "Default Name");
    }

    public static int LoadScore()
    {
        return PlayerPrefs.GetInt(scoreKey, 0);
    }
}
