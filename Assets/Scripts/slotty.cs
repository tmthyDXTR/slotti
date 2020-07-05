using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slotty : MonoBehaviour
{
    static string symbol1 = "1";
    static string symbol2 = "2";
    static string symbol3 = "3";
    static string symbol4 = "4";
    static string symbol5 = "5";
    static string symbol6 = "6";
    static string symbol7 = "420";
    static string symbol8 = "Wubi";
    static string symbol9 = "Dubi";
    static string symbol10 = "Leiter";
    static string symbol11 = "Lampe";
    static string symbol12 = "Lunte";



    public Dictionary<string, int> dict = new Dictionary<string, int>()
    {
        {symbol1, 80 },
        {symbol2, 80 },
        {symbol3, 80 },
        {symbol4, 80 },
        {symbol5, 80 },
        {symbol6, 80 },
        {symbol7, 50 },
        {symbol8, 40 },
        {symbol9, 30 },
        {symbol10, 20 },
        {symbol11, 15 }
        
    };

    private List<string> CreateString(Dictionary<string, int> dict)
    {
        var result = new List<string>();

        foreach (var symbol in dict)
        {
            for (int i = 0; i < symbol.Value; i++)
            {
                result.Add(symbol.Key);
            }
        }

        return result;
    }

    private string TakeRandomSymbol(List<string> symbolList)
    {
        int selected = UnityEngine.Random.Range(0, symbolList.Count);

        dict[symbolList[selected]]--;


        return symbolList[selected];
    }
       
    //
    // Then randomly select a value from that list:
    //
    //private int selected = values[Random.Range(0, values.Length)];


    // Start is called before the first frame update
    void Start()
    {
        var stringList = CreateString(dict);
        //foreach (var item in stringList)
        //{
        //    Debug.Log(item);
        //}
        for (int i = 0; i < 15; i++)
        {
            Debug.Log(TakeRandomSymbol(stringList));

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
