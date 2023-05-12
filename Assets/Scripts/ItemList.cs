using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemList : MonoBehaviour
{
    private Dictionary<string, int> Items;
    
    private void Start()
    {
        Items = new Dictionary<string, int>()
        {
            {"position", 5},
            {"Antidote", 8},
            {"Aspirin", 1}
        };
        var playerMoney = 5;
        foreach (var item in Items)
        {
            if (playerMoney >= item.Value)
            {
                Debug.LogFormat("Item: {0} - {1}g, お金払えば、持っていけ！", item.Key, item.Value);
            }
            else
            {
                Debug.LogFormat("Item: {0} - {1}g, お金が足りないよ", item.Key, item.Value);
            }
        }

        
        
    }
}
