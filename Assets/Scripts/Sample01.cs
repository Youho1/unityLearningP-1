using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sample01 : MonoBehaviour
{
    //string firstname = "YF";
    void Start()
    {
        Character myCharacter = new Character("Zero", new EXP(), new Level());
        Debug.Log($"playername:{myCharacter.GetName()}");
        myCharacter.GetExp().Add(new EXP(10), myCharacter);
        myCharacter.GetExp().Add(new EXP(10), myCharacter);
        myCharacter.GetExp().Add(new EXP(10), myCharacter);
        myCharacter.GetExp().Add(new EXP(10), myCharacter);
        myCharacter.GetExp().Add(new EXP(10), myCharacter);
        myCharacter.GetExp().Add(new EXP(10), myCharacter);
        myCharacter.GetExp().Add(new EXP(10), myCharacter);
        myCharacter.GetExp().Add(new EXP(10), myCharacter);
        myCharacter.GetExp().Add(new EXP(10), myCharacter);
        myCharacter.GetExp().Add(new EXP(10), myCharacter);
        myCharacter.GetExp().Add(new EXP(10), myCharacter);
        myCharacter.GetExp().Add(new EXP(10), myCharacter);
        myCharacter.GetExp().Add(new EXP(10), myCharacter);
        myCharacter.GetExp().Subtract(new EXP(20));
        myCharacter.GetExp().Subtract(new EXP(20));
        //Debug.Log($"文字列には{firstname}のような変数を挿入できる");
        Weapon huntingBow = new Weapon("Hunting Bow", 105);
        huntingBow.PrintWeaponStatus();
    }
    
}
