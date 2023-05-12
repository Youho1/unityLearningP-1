using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceGame : MonoBehaviour
{
    private void Start()
    {
        var diceRoll = (int)Random.Range(0, 21);
        switch (diceRoll)
        {
            case 7:
            case 15:
                Debug.Log("中程度のダメージ。悪くないよ。");
                break;
            case 20:
                Debug.Log("急所にあたった。怪物が倒れるぞ！");
                break;
            default:
                Debug.Log("的を外した君は、ぱったり倒れた。");
                break;
        }
    }
}
