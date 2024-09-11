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
    
}