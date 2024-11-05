using UnityEngine;

/*
(Placar final) Crie um script que l� o placar de uma partida entre
time A e time B. Depois, escreva no console qual dos tr�s
resultados poss�veis aconteceu: vit�ria do time A, vit�ria do time B
ou empate. Se o empate teve mais de 3 pontos para cada lado,
escreva que foi �um empate emocionante�.
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
            print("vit�ria do time A");
        }        
        else
        {
            print("vit�ria do time B");
        }
    }

    void Update()
    {
        
    }
}
