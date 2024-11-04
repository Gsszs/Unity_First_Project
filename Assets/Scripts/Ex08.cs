using UnityEngine;
using System.Threading.Tasks;

/*
(Contador de horas e dias) Crie um script que em que uma
variável inteira hora seja incrementada de uma unidade a cada 10
segundos e volte a ser 0 quando alcançar o valor 24. Quando
completar um ciclo, incremente uma variável dias e escreva o
número de dias que se passaram no console. (Coloque o código
dentro da função-evento Update).
*/

public class Ex08 : MonoBehaviour
{
    [SerializeField] int hora = 1, dia = 1;
    void Start()
    {   
        while(true)
        {
            print("Horas: " + hora + " Dias: " + dia);
            Task.Delay(10 * 1000);

            if (hora == 24)
            {
                hora = 0;
                dia += 1;
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
