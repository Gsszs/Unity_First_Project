using UnityEngine;

/*
(C�lculo de moedas coletadas) O jogador coleta 3 moedas a
cada fase. Ap�s 10 fases, exiba o total de moedas coletadas.
*/

public class Ex3 : MonoBehaviour
{
    int moedas = 0;
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            moedas += 3;
        }
        print($"Moedas coletadas: {moedas}");
    }

    void Update()
    {
        
    }
}
