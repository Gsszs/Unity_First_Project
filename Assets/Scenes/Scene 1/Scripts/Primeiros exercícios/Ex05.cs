using UnityEngine;

/*
(Pontua��o de miss�o) Ap�s completar uma miss�o, o jogador
recebe pontos. Verifique se ele ganhou mais de 50 pontos. Se sim,
exiba "Miss�o bem-sucedida"; caso contr�rio, "Miss�o
incompleta".
*/

public class Ex05 : MonoBehaviour
{

    [SerializeField] int pontosJogador = 30;
    void Start()
    {
        print(pontosJogador >= 50 ? "Miss�o bem-sucedida" : "Miss�o incompleta");
    }

    void Update()
    {
        
    }
}
