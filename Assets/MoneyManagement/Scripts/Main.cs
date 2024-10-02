using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class test
{
    public string a;
    public int b;
}

public class Main : MonoBehaviour
{
    public MainManager mainManager;
    public UserData userData;

    void Start()
    {
        userData = new UserData();
        userData.Init();

        mainManager.Init();
    }

    public static void Save()
    {
        //error
        //string userDataJSON = JsonUtility.ToJson(userData);
    }
}
