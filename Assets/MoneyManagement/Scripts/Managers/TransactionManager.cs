using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TransactionType
{
    Incoming,
    Outgoing
}

public class Transaction 
{
    public float amount;
    public DateTime dateTime;
    public TransactionType type;
    
    public string note;
}

public class TransactionManager
{
    UserData userData;

    public void Init(MainManager mainManager)
    {
        userData = mainManager.userData;
    }

    public void AddTransaction(Transaction transaction)
    {
        WalletData currentWallet = GetCurrentWallet();

        if(currentWallet != null)
        {
            currentWallet.transactionList.Add(transaction);
            Util.Log("TransactionManager: Transaction added to wallet " + userData.currentWalletID);
        }
    }

    public void RemoveTransaction(Transaction transaction)
    {
        WalletData currentWallet = GetCurrentWallet();
        if (currentWallet != null)
        {
            if (currentWallet.transactionList.Contains(transaction))
            {
                currentWallet.transactionList.Remove(transaction);
            }
        }
    }

    public WalletData GetCurrentWallet()
    {
        WalletData result = null;

        int currentWalletID = userData.currentWalletID;

        int walletCount = userData.walletDatas.Count;
        for (int i = 0; i < walletCount; i++)
        {
            WalletData walletData = userData.walletDatas[i];
            int walletID = walletData.walletID;
            if(currentWalletID == walletID)
            {
                result = walletData;
                break;
            }
        }

        return result;
    }
}