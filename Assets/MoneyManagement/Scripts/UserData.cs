using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class WalletData
{
    public int walletID;
    public string walletName;
    public string currency;
    public List<Transaction> transactionList;
}

public class UserData
{
    public bool firstTimeUser = true;

    public List<WalletData> walletDatas;
    public int currentWalletID;

    public void Init() 
    {
        if (firstTimeUser)
        {
            walletDatas = new List<WalletData>();
            firstTimeUser = false;
        }


    }
}
