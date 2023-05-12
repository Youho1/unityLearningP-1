using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sample01 : MonoBehaviour
{
    string firstname = "YF";
    void Start()
    {
        Debug.Log($"文字列には{firstname}のような変数を挿入できる");
    }
    
}
