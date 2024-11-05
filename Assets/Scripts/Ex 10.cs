using UnityEngine;

/*
(Itens do inventário) Crie um script onde o jogador pode coletar
diferentes tipos de itens (como moedas, poções, ou power-ups)
que têm efeitos diferentes dependendo do tipo coletado. Use um
switch case para determinar o efeito de cada tipo de item.
*/

public class Ex10 : MonoBehaviour
{
    [SerializeField] int itens = 0;
    void Start()
    {
        switch (itens)
        {
            case 0:
                print("Coletou moedas!");
                break;

            case 1:
                print("Coletou poções!");
                break;

            case 2:
                print("Coletou power-ups!");
                break;

            case 3:
                print("Coletou espada!");
                break;

            default:
                print("Não conseguiu coletar nenhum item!");
                break;
        }
    }

    void Update()
    {
        
    }
}
