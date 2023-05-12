using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionSelect : MonoBehaviour
{
    private enum ActionType
    {
        Attack,
        Heal,
        Run
    }

    [SerializeField] private ActionType action;
    private void Start()
    {
        switch (action)
        {
            case ActionType.Attack:
                Debug.Log("闘え！");
                break;
            case ActionType.Heal:
                Debug.Log("薬を送ったぞ。");
                break;
            case ActionType.Run:
                Debug.Log("みんな、逃げるぞ！");
                break;
            default: 
                Debug.Log("防御せよ！");
                break;
        }
    }
}
