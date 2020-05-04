﻿using UnityEngine;
using UnityEditor;
using System.IO;

public class Logger
{
    static float previous = 0;
    static public void writeString(string input) {
        string path = "Assets/Resources/";
        string filename = "DebugLog.txt";
        StreamWriter writer = new StreamWriter(path + filename, true);
        writer.WriteLine(input + " : Time: " + Time.time + " Time since last log : " + (Time.time - previous));
        writer.Close();
        previous = Time.time;
    }
}
