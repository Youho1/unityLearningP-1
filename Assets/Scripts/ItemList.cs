using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemList : MonoBehaviour
{
    private void Start()
    {
        Dictionary<string, int> ItemInventory = new Dictionary<string, int>()
        {
            {"position", 5},
            {"Antidote", 8},
            {"Aspirin", 1}
        };
        
        Debug.LogFormat("Item: {0}", ItemInventory.Count);
    }
}
