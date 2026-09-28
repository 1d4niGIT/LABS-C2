using UnityEngine;

public class Pokemon : MonoBehaviour
{
    //Atributos
    public string nombre;
    public string tipo;
    public int nivel;

    //Comportamientos
    public void Atacar()
    {
        Debug.Log(nombre + " ha realizado un ataque.");
    }
}
