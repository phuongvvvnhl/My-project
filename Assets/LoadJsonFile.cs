using System;
using System.Collections.Generic;
using UnityEngine;

public class LoadJsonFile : MonoBehaviour
{
    public static LoadJsonFile instance;
    string filePath = "Assets/Resources/Data/saokedata.json";
    public TransactionList listgiaodich = new TransactionList();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        instance = this;
        listgiaodich = ReadJsonFile();
        //ReadJsonFile();

    }

    // Update is called once per frame
    void Update()
    {

    }


    TransactionList ReadJsonFile()
    {
        string jsonContent = System.IO.File.ReadAllText(filePath);

        return JsonUtility.FromJson<TransactionList>(jsonContent);
    }

    public List<Transaction> FindTransactionsByDetail( string keyword)
    {
        Transaction[] transactions = listgiaodich.transactions;
        List<Transaction> foundTransactions = new List<Transaction>();
        foreach (Transaction transaction in transactions)
        {
            if (transaction.transactionDetail.Contains(keyword, StringComparison.OrdinalIgnoreCase))
            {
                foundTransactions.Add(transaction);
            }
        }
        return foundTransactions;
    }

}
[System.Serializable]
public class Transaction
{
    public string txnDate;
    public string docNo;
    public double debit;
    public double credit;
    public double balance;
    public string transactionDetail;
}

[System.Serializable]
public class TransactionList
{
    public Transaction[] transactions;
}