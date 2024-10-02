using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public enum LogType 
{
    Log,
    Warning,
    Error
}

public static class Util
{
    public static void Log(string message, LogType type = LogType.Log)
    {
        switch (type)
        {
            case LogType.Log:
                Debug.Log(message);
                break;
            case LogType.Warning:
                Debug.LogWarning(message);
                break;
            case LogType.Error:
                Debug.LogError(message);
                break;
        }
    }
}
