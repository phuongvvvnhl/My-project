using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Progress;

public class SearchButton : MonoBehaviour
{
    public TMP_InputField keyword, time, amount;
    public Transform ResultContent;
    public GameObject ResultItem;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //ResultItem = Resources.Load<GameObject>("ContentItem");
        GetComponent<Button>().onClick.AddListener(() =>
        {
            EmptyContent();
            List<Transaction> result = LoadJsonFile.instance.FindTransactionsByDetail(keyword.text);
            foreach (Transaction t in result)
            {
                //Debug.Log(t.transactionDetail);
                GameObject gg = Instantiate(ResultItem, ResultContent);
                ContentItem cc = gg.GetComponent<ContentItem>();
                cc.SetData(t);
            }
        });
    }

    public void EmptyContent()
    {
        foreach (Transform item in ResultContent)
        {
            Destroy(item.gameObject);
        }
    }


    // Update is called once per frame
    void Update()
    {

    }
}

