using UnityEngine;
public struct Weapon 
{
    public string _name;
    public int _damage;

    public Weapon(string name, int damage)
    {
        _name = name;
        _damage = damage;
    }

    public void PrintWeaponStatus()
    {
        Debug.LogFormat("Weapon: {0} - {1} DMB", _name, _damage);
    }
}
