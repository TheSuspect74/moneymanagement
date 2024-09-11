using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class CountryDB
{
    public string name;
    public string symbol;
}

public class DBManager
{
    public CountryDB[] countryDBs;

    public void Init(MainManager mainManager)
    {

    }
}
