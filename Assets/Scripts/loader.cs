﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using SimpleJSON;
using TMPro;
using System;

public class loader : MonoBehaviour
{
    public GameObject placements;
    public GameObject scores;
    static private int totalloader = 0;

    void leaderboard(Highscore[] highscores)
    {
        Array.Sort(highscores);
        //Array.Reverse(highscores);
        TextMeshProUGUI[] places = placements.GetComponentsInChildren<TextMeshProUGUI>();
        TextMeshProUGUI[] numbers = scores.GetComponentsInChildren<TextMeshProUGUI>();
        for (int i = 0; i < places.Length; i++) {
            places[i].text = i + 1 + ". " + highscores[i].getName();
            numbers[i].text = highscores[i].getScore() + "";
        }
    }

    Highscore[] Load()
    {

        Debug.Log("I AM LOADING");
        string path = Application.dataPath + totalloader + ".json";
        string jsonString = File.ReadAllText(path);
        JSONObject playerJson = (JSONObject)JSON.Parse(jsonString);

        string[] highscoreN = new string[6];
        int[] highscoreS = new int[6];

        highscoreN[0] = playerJson["highscoreN0"];
        highscoreN[1] = playerJson["highscoreN1"];
        highscoreN[2] = playerJson["highscoreN2"];
        highscoreN[3] = playerJson["highscoreN3"];
        highscoreN[4] = playerJson["highscoreN4"];
        highscoreN[5] = playerJson["highscoreN5"];


        highscoreS[0] = playerJson["highscoreS0"];
        highscoreS[1] = playerJson["highscoreS1"];
        highscoreS[2] = playerJson["highscoreS2"];
        highscoreS[3] = playerJson["highscoreS3"];
        highscoreS[4] = playerJson["highscoreS4"];
        highscoreS[5] = playerJson["highscoreS5"];

        Highscore[] highscores = new Highscore[6];
        for (int i = 0; i < 6; i++)
        {
            highscores[i] = new Highscore(highscoreN[i], highscoreS[i]);
        }

        GameObject.Find("level_x").GetComponent<TextMeshProUGUI>().text = playerJson["level"];

        totalloader++;
        return highscores;
    }
    void Start()
    {
        leaderboard(Load());
    }
    
}

