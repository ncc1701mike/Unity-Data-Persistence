using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{

    public void StartNew()
    {
        // add code here to handle when the user click on the Start New button
        SceneManager.LoadScene(1);
    }

    public void ExitMain()
    {
        // add code here to handle when the user click on the Exit button
        SceneManager.LoadScene(0);
    }

    public void ExitGame()
    {
        #if UNITY_EDITOR
            EditorApplication.ExitPlaymode();
        
        #else
            Application.Quit();

        #endif
    }

}
