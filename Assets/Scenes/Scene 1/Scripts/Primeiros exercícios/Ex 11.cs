using UnityEngine;

/*
(Diálogos) Implemente um sistema de diálogos onde o jogador
pode interagir com um NPC (personagem não jogável), e o NPC
responde com diferentes frases dependendo do estado do jogo.
Use switch case para definir as respostas baseadas no estado do
jogador.
*/

public class Ex11 : MonoBehaviour
{
    [SerializeField] int estadoDoJogo = 3;
    void Start()
    {
        switch(estadoDoJogo)
        {
            case 0:
                print("Bem vindo ao jogo herói!");
                break;

            case 1:
                print("Parabéns por completar a fase 1!");
                break;

            case 2:
                print("Você coletou uma moeda!");
                break;

            case 3:
                print("Parabéns por derrotar todos os inimigos!");
                break;

            case 4:
                print("Você conquistou o emblema de herói II !");
                break;

            case 5:
                print("Cuidado! Agora você vai enfrentar o BOSS FINAL !!!");
                break;

            case 6:
                print("Você está quase conseguindo!");
                break;

            case 7:
                print("Muito obrigado por jogar!");
                break;
        }
    }

    void Update()
    {
        
    }
}
