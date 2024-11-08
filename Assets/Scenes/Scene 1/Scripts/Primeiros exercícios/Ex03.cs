using UnityEngine;

public class Ex03 : MonoBehaviour
{
    [SerializeField] bool powerup = true;
    [SerializeField] int vidaJogador = 100;
    [SerializeField] int dano = 120;
    void Start()
    {
        print("---------------------- EX3 ----------------------\n\n");
        int armazenarVidaJogador = vidaJogador;
        vidaJogador -= dano;

        if (vidaJogador <= 0 && powerup)
        {
            vidaJogador = armazenarVidaJogador / 2;
            print($"Ainda não, vida atual {vidaJogador}");
        }
        else if (vidaJogador <= 0)
        {
            print("Game Over"); 
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
