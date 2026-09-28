using UnityEngine;

[System.Serializable]
public class Weapon 
{
    [SerializeField] private string weaponName = "Pistola";
    [SerializeField] private int damage = 15;
    [SerializeField] private int ammo = 5;
    [SerializeField] private bool haveAmmo = true;

    public bool Attack( Health target)
    {
        if (!haveAmmo)
            Debug.Log("No queda munición");
        else
        {
            ammo--;
            target.TakeDamage(damage);
        }
        if (target == null) Debug.Log("No hay target");

        return false; 
    }

    public string GetName()
    {
        return weaponName;
    }

    public int GetDamage()
    {
        return damage;
    }

    public int GetAmmo()
    {
        return ammo;
    }

    public void Reload(int bullets)
    {
        if (bullets > 0) ammo += bullets;
    }
}
