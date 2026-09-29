using UnityEngine;

public class BaseStats 
{
    // Propiedad automática: C# crea el campo escondido por ti
    public int Strength { get; private set; }

    // Propiedad con campo propio: tú escribes el campo y la lógica
    private int health; // campo: la variable que guarda el dato

    public int Health // propiedad: la "puerta" para leer/modificar ese campo
    {
        get { return health; }
        private set { health = value < 0 ? 0 : value; }
    }

    public BaseStats (int strength, int health)
    {
        Strength = strength;
        Health = health;
    }

    public void TakeDamage(int amount)
    {
        Health -= amount;
    }
}
