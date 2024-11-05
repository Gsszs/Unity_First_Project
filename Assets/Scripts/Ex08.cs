using UnityEngine;
using System.Threading.Tasks;

/*
(Contador de horas e dias) Crie um script que em que uma
vari�vel inteira hora seja incrementada de uma unidade a cada 10
segundos e volte a ser 0 quando alcan�ar o valor 24. Quando
completar um ciclo, incremente uma vari�vel dias e escreva o
n�mero de dias que se passaram no console. (Coloque o c�digo
dentro da fun��o-evento Update).
*/

public class Ex08 : MonoBehaviour
{
    [SerializeField] int hora = 0, dia = 0, segundos = 0;
    void Start()
    {   
        
    }

    // Update is called once per frame
    void Update()
    {
        segundos++;
        if (segundos % 1000 == 0)
        {
            hora++;
            print("Horas: " + hora);
        }

        if (hora == 24)
        {
            hora = 0;
            dia += 1;
            print(dia <= 1 ? "Dia: " + dia : "Dias: " + dia);
        }
    }
}
