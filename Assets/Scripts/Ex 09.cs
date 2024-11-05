using UnityEngine;

/*
(Placar final) Crie um script que lê o placar de uma partida entre
time A e time B. Depois, escreva no console qual dos três
resultados possíveis aconteceu: vitória do time A, vitória do time B
ou empate. Se o empate teve mais de 3 pontos para cada lado,
escreva que foi “um empate emocionante”.
*/

public class Ex09 : MonoBehaviour
{
    [SerializeField] int timeA = 3, timeB = 3;
    void Start()
    {
        if (timeA == timeB && timeA >= 3)
        {
            print("um empate emocionante");
        } 
        else if (timeA == timeB) 
        {
            print("empate");
        }
        else if (timeA > timeB)
        {
            print("vitória do time A");
        }        
        else
        {
            print("vitória do time B");
        }
    }

    void Update()
    {
        
    }
}
