﻿
using UnityEngine;
using UnityEngine.UI;

public class button_quit_game : MonoBehaviour
{
    public Button yourButton;

    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(QuitGame);
    }

    void QuitGame() 
    {
        
        Debug.Log("Game is exiting");
        Application.Quit();
        //Just to make sure its working
        // save any game data here
        #if UNITY_EDITOR
        // Application.Quit() does not work in the editor so
        // UnityEditor.EditorApplication.isPlaying need to be set to false to end the game
        UnityEditor.EditorApplication.isPlaying = false;
        #else
         Application.Quit();
        #endif
    }
}