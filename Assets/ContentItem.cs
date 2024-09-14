using Assets;
using System;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class ContentItem : MonoBehaviour
{
    public TextMeshProUGUI date, docno, debit, credit, balance, detail,docChu;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    public void SetData(Transaction tran)
    {
        date.text = tran.txnDate;
        docno.text = tran.docNo;
        debit.text = String.Format("{0:0,0}", tran.debit);
        credit.text = String.Format("{0:0,0}", tran.credit);
        balance.text = String.Format("{0:0,0}", tran.balance);
        detail.text = tran.transactionDetail;
        docChu.text = DocSoThanhChu.NumberToWords((int)tran.credit)+" Đồng";
        //number.ToString("#,##0")
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
