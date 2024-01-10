using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveButtonScript : MonoBehaviour
{
    public PlayerName playerNameScript;
    public MainManager mainManagerScript;

    public void OnClick()
    {
        string playerName = playerNameScript.playerName;
        int score = mainManagerScript.GetScore();
        DataPersistenceManager.SaveData(playerName, score);
    }
}
