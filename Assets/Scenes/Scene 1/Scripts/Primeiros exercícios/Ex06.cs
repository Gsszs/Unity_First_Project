using UnityEngine;

/*
(Escolha de personagem) O jogador pode escolher entre o
personagem Guerreiro ou Mago. Exiba "Guerreiro escolhido" se o
jogador selecionar Guerreiro e "Mago escolhido" se selecionar
Mago.
*/

public class Ex06 : MonoBehaviour
{
    [SerializeField] bool Guerreiro = false;
    void Start()
    {
        print(Guerreiro ? "Guerreiro escolhido" : "Mago escolhido");
    }

    void Update()
    {
        
    }
}
