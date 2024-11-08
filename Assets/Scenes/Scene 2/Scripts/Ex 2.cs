using UnityEngine;

/*
(Multiplicação de dano) Um personagem ataca cinco vezes, e o
dano do ataque aumenta em 2 a cada vez. Exiba o dano a cada
ataque.
*/
public class Ex2 : MonoBehaviour
{
    void Start()
    {
        int dano = Random.Range(1, 5);
        for (int i = 0; i < 5; i++)
        {
            print($"Dano: {dano}");
            dano+=2;
        }
    }

    void Update()
    {
        
    }
}
