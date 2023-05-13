using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// character class
/// </summary>
public class Character : MonoBehaviour
{
    private string _name;
    private EXP _exp;
    private Level _level;

    public Character(string name, EXP exp, Level level)
    {
        _name = name;
        _exp = exp;
        _level = level;
    }

    public string GetName()
    {
        return _name;
    }

    public EXP GetExp()
    {
        return _exp;
    }

    public Level GetLevel()
    {
        return _level;
    }

    public void ResetName(string newName)
    {
        _name = newName; 
    }
    
}

public class EXP
{
    private int _exp;

    public EXP(int exp = 0)
    {
        _exp = exp;
    }

    public void Add(EXP exp, Character character)
    {
        _exp += exp._exp;
        while (_exp >= 100)
        {
            _exp -= 100;
            character.GetLevel().Up();
        }
        Debug.Log($"Exp:{_exp}");
    }

    public void Subtract(EXP exp)
    {
        _exp -= exp._exp;
        if (_exp < 0)
        { 
            _exp = 0;
        }
        Debug.Log($"Exp:{_exp}");
    }

    public int Get()
    {
        return _exp;
    }
}

public class Level
{
    private int _level;

    public Level(int level = 1)
    {
        _level = level;
    }

    public void Up()
    {
        _level++;
        Debug.Log("Level up!!!");
    }

    public int Get()
    {
        return _level;                                                                                                                         
    }
    /*
    public void Down()
    {
        _level--;
        Debug.Log("Level Down...");
    }
    */
}

