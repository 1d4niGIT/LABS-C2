using UnityEngine;

public class Entrenador : MonoBehaviour
{
    void Start()
    {
        Pokemon pikachu = gameObject.AddComponent<Pokemon>();
        pikachu.nombre = "Pikachu";
        pikachu.tipo = "Eléctrico";
        pikachu.nivel = 10;
        pikachu.Atacar();
    }
   
}
