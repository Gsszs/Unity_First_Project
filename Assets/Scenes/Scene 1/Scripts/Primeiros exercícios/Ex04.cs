using UnityEngine;
using static UnityEditor.Progress;

/*
(Verificar item de inventário) Um jogador possui itens limitados
no inventário. Verifique se o jogador possui uma "Poção de Vida".
Se possuir, exiba "Usando Poção de Vida"; caso contrário, "Poção
indisponível".
*/

public class Ex04 : MonoBehaviour
{

    [SerializeField] bool temPocaoVida = true;
    void Start()
    {
        print(temPocaoVida ? "Usando Poção de Vida" : "Poção indisponível");
    }

    void Update()
    {
        
    }
}
