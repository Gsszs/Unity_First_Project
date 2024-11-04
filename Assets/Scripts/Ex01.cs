using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Ex01 : MonoBehaviour
{   
    double vidaJogador = 10, Dano = 5;
    void Start()
    {
        print("---------------------- EX1 ----------------------\n\n");
        vidaJogador -= Dano;
        print(vidaJogador > 0 ? "Jogador Vivo" : "Game Over");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
