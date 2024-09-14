using UnityEngine;
using UnityEngine.UI;

public class SearchButton : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(() =>
        {
            //foreach (var item in LoadJsonFile.instance.listgiaodich.transactions)
            //{
            //    Debug.Log(item.transactionDetail);
            //}
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

