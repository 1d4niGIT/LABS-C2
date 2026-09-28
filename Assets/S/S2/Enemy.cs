using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private string enemyName = "Slime";
    [SerializeField] private Health health = new Health();
    void Start()
    {
        
    }
    public void TakeDamage (int damage)
    {
        health.TakeDamage(damage);
        if (health.IsDead())
        {
            Debug.Log("El enemigo " + GetName() + " ha muerto");
        }    
    }

    public string GetName()
    {
        return enemyName;
    }

    public Health GetHealth()
    {
        return health;
    }

    public bool IsDead()
    {
        return health.IsDead();
    }

    [ContextMenu("Imprimir estado")]
    public void PrintStatus()
    {
        Debug.Log(enemyName +
            "| vida " + health.GetHealth() + "/" + health.GetMaxHealth() +
            "| muerto: " + health.IsDead());
    }

}
