using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnToMenuButtonScript : MonoBehaviour
{
    
    public MainManager mainManagerScript;
    public PlayerName playerNameScript;

    public void OnClick()
    {
        string playerName = playerNameScript.playerName;
        int score = mainManagerScript.GetScore();
        DataPersistenceManager.SaveData(playerName, score);

    }

}
