using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayPlayerName : MonoBehaviour
{
    public TMPro.TextMeshProUGUI playernameText;
    // Start is called before the first frame update
    void Start()
    {
        playernameText.text = PlayerName.Instance.playerName;
    }

}
