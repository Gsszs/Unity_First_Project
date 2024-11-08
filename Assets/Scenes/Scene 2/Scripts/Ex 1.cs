using UnityEngine;

/*
(Contagem regressiva de tempo) Crie uma contagem
regressiva de 5 a 1 e exiba "Início da partida!" ao final.
*/

public class Ex1 : MonoBehaviour
{
    void Start()
    {
        for (int i = 5; i >= 1; i--)
        {
            print(i);
        }
        print("Início da partida!");
    }

    void Update()
    {
        
    }
}
