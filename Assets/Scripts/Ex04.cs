using UnityEngine;
using static UnityEditor.Progress;

/*
(Verificar item de invent�rio) Um jogador possui itens limitados
no invent�rio. Verifique se o jogador possui uma "Po��o de Vida".
Se possuir, exiba "Usando Po��o de Vida"; caso contr�rio, "Po��o
indispon�vel".
*/

public class Ex04 : MonoBehaviour
{

    [SerializeField] bool temPocaoVida = true;
    void Start()
    {
        print(temPocaoVida ? "Usando Po��o de Vida" : "Po��o indispon�vel");
    }

    void Update()
    {
        
    }
}
