using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager
{
    public UserData userData;
    public TransactionManager transactionManager;

    public void Init()
    {
        transactionManager = new TransactionManager();

        userData.Init();
        transactionManager.Init(this);
    }
}
