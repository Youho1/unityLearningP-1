using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool isLives(int hp)
    {
        if (hp > 0)
        {
            return true;
        }

        return false;
    }

    private void Start()
    {
        var hitPoint = 20;
        Debug.Log($"ヒットポイント:{hitPoint}");
        while (isLives(hitPoint))
        {
            Debug.Log("ダメージ1を受けました！");
            Debug.LogFormat("hitPointは{0}になりました。", --hitPoint);
        }

        if (hitPoint <= 0)
        {
            hitPoint = 0;
            Debug.Log("ゲームオーバー!");
        }
        
    }
}
