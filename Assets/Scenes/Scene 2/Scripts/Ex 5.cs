using UnityEngine;

/*
(Aumento de nível de dificuldade) A cada fase completada, a
dificuldade aumenta em 5 pontos. Exiba a dificuldade após cada
fase, em um total de 6 fases.
*/

public class Ex5 : MonoBehaviour
{
    void Start()
    {
        int dificuldade = Random.Range(1, 5);
        for (int i = 1; i <= 6; i++)
        {
            print($"Dificuldade fase {i}: {dificuldade}");
            dificuldade += 5;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
