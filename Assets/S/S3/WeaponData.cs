using UnityEngine;
using UnityEngine.Rendering;

public class WeaponData
{
   public string Name { get; private set; }
   public int Damage { get; private set; }
   public float Range { get; private set; }
   public float AttackInterval { get; private set; }

    public WeaponData (string name, int damage, float range, float attackInterval)
    {
        Name = name;
        Damage = damage;
        Range = range;
        AttackInterval = attackInterval;
    }

}
