using UnityEngine;

/*
(Pontua��o em combos) Cada combo realizado aumenta em 10
pontos. Exiba a pontua��o total ap�s 7 combos.
*/

public class Ex4 : MonoBehaviour
{
    void Start()
    {
        int pontos = Random.Range(1, 19);
        print($"Pontos iniciais: {pontos}");
        for (int i = 0; i < 5; i++)
        {
            pontos += 10;
        }
        print($"Pontos finais: {pontos}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
