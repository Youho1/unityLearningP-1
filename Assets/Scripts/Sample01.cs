using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sample01 : MonoBehaviour
{
    //string firstname = "YF";
    void Start()
    {
        Paladin knight = new Paladin("Zero");
        Debug.Log($"playername:{knight.GetName()}, level: {knight.GetLevel().Get()}");
        knight.GetExp().Add(new EXP(10), knight);
        knight.GetExp().Add(new EXP(10), knight);
        knight.GetExp().Add(new EXP(10), knight);
        knight.GetExp().Add(new EXP(10), knight);
        knight.GetExp().Add(new EXP(10), knight);
        knight.GetExp().Add(new EXP(10), knight);
        knight.GetExp().Add(new EXP(10), knight);
        knight.GetExp().Add(new EXP(10), knight);
        knight.GetExp().Add(new EXP(10), knight);
        knight.GetExp().Add(new EXP(10), knight);
        knight.GetExp().Add(new EXP(10), knight);
        knight.GetExp().Add(new EXP(10), knight);
        knight.GetExp().Add(new EXP(10), knight);
        knight.GetExp().Subtract(new EXP(20));
        knight.GetExp().Subtract(new EXP(20));
        Debug.Log($"playername:{knight.GetName()}, level: {knight.GetLevel().Get()}");
        //Debug.Log($"文字列には{firstname}のような変数を挿入できる");
        Weapon huntingBow = new Weapon("Hunting Bow", 105);
        huntingBow.PrintWeaponStatus();
    }
    
}
