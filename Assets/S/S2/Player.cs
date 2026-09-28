using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private string playerName = "Jugador 1";
    [SerializeField] private Health health = new Health();
    [SerializeField] private Weapon weapon = new Weapon();

    [Header("A quien ataco")]
    [SerializeField] private Enemy defaultTarget;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Atacando");
            Attack(defaultTarget);
        }

        if(Input.GetKeyDown(KeyCode.H))
        {
            Heal(10);
        }

        if(Input.GetKeyDown(KeyCode.P))
        {
            PrintStatus();
        }
    }

    public void Attack (Enemy target)
    {
        weapon.Attack(target.GetHealth());
    }

    public void TakeDamage(int damage)
    {
        health.TakeDamage(damage);  
    }

    public void Heal(int amount)
    {
        health.Heal(amount);
        Debug.Log(playerName + " se cura " + amount + ". Vida; " + health.GetHealth());
    }

    public string GetName()
    {
        return playerName;
    }

    public Health GetHealth()
    {
        return health;
    }

    public Weapon GetWeapon()
    {
        return weapon;
    }

    public bool IsAlive()
    {
        return !health.IsDead();
    }

    [ContextMenu("Imprimir estado")]
    public void PrintStatus()
    {
        Debug.Log(playerName +
            "| vida " + health.GetHealth() + "/" + health.GetMaxHealth() +
            "| arma " + weapon.GetName() +
            "| balas " + weapon.GetAmmo());
    }

}
