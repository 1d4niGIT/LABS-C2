using UnityEngine;

public class EnemyS3 : MonoBehaviour
{
    private BaseStats stats;

    void Awake()
    {
        stats = new BaseStats(5, 30);
        Debug.Log("Enemy nació con vida: " + stats.Health);
    }

    public void TakeDamage (int amount)
    {
        stats.TakeDamage(amount);
        Debug.Log("Enemy recibió " + amount + ", vida restante: " + stats.Health);

        if (stats.Health <= 0)
        {
            Destroy(gameObject);
        }
    }

    void OnDestroy()
    {
        Debug.Log("Unity destruyó este Enemy");
    }
}
