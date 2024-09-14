using System;
using System.Collections.Generic;
using UnityEngine;

public class LoadJsonFile : MonoBehaviour
{
    public static LoadJsonFile instance;
    string filePath = "Assets/Resources/Data/saokedata.json";
    TransactionList listgiaodich = new TransactionList();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        instance = this;
        listgiaodich = ReadJsonFile();
        //ReadJsonFile();
        foreach (Transaction t in listgiaodich.transactions)
        {
            Debug.Log(t.transactionDetail);
        }
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
}
[System.Serializable]
public class Transaction
{
    public DateTime txnDate { get; set; }
    public string docNo { get; set; }
    public int debit { get; set; }
    public int credit { get; set; }
    public int balance { get; set; }
    public string transactionDetail { get; set; }
}
[System.Serializable]
public class TransactionList
{
    public List<Transaction> transactions { get; set; }
}