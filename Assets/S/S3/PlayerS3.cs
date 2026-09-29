using UnityEngine;

public class PlayerS3 : MonoBehaviour
{
    private BaseStats stats;
    private WeaponData weapon;

    private float timer;

    void Update()
    {
        if (weapon == null) return;
        timer += Time.deltaTime;

        if (timer >= weapon.AttackInterval)
        {
            Debug.Log("Voy a atacar");
            Attack();
            timer = 0f;
        }
    }

    void Awake()
    {
        stats = new BaseStats(10, 100);
    }

    void Start()
    {
        SetWeapon( new WeaponData("Espada de Hierro", 10, 6f, 1f));
        Debug.Log("Arma asignada " + weapon.Name);
    }

    public void SetWeapon (WeaponData weaponData)
    {
        weapon = weaponData;
    }    

    public void TakeDamage(int amount)
    {
        stats.TakeDamage(amount);
    }

    void Attack()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        Debug.Log("Enemigos encontrados: " + enemies.Length);

        foreach (GameObject enemyObject in enemies)
        {
            float distance = Vector3.Distance(transform.position, enemyObject.transform.position);
            Debug.Log("Distancia: " + distance + " | Rango: " + weapon.Range);

            if (distance <= weapon.Range)
            {
                Debug.Log("En rango, aplicando daño");
                enemyObject.GetComponent<EnemyS3>().TakeDamage(weapon.Damage);
            }
        }

    }
}
