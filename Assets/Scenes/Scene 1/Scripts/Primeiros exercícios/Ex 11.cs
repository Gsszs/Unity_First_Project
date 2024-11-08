using UnityEngine;

/*
(Di�logos) Implemente um sistema de di�logos onde o jogador
pode interagir com um NPC (personagem n�o jog�vel), e o NPC
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
                print("Bem vindo ao jogo her�i!");
                break;

            case 1:
                print("Parab�ns por completar a fase 1!");
                break;

            case 2:
                print("Voc� coletou uma moeda!");
                break;

            case 3:
                print("Parab�ns por derrotar todos os inimigos!");
                break;

            case 4:
                print("Voc� conquistou o emblema de her�i II !");
                break;

            case 5:
                print("Cuidado! Agora voc� vai enfrentar o BOSS FINAL !!!");
                break;

            case 6:
                print("Voc� est� quase conseguindo!");
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
