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

        foreach (var item in Items)
        { 
            Debug.LogFormat("Item: {0} - {1}g", item.Key, item.Value);  
        }
        
    }
}
