using UnityEngine;

/*
(Pontuação de missão) Após completar uma missão, o jogador
recebe pontos. Verifique se ele ganhou mais de 50 pontos. Se sim,
exiba "Missão bem-sucedida"; caso contrário, "Missão
incompleta".
*/

public class Ex05 : MonoBehaviour
{

    [SerializeField] int pontosJogador = 30;
    void Start()
    {
        print(pontosJogador >= 50 ? "Missão bem-sucedida" : "Missão incompleta");
    }

    void Update()
    {
        
    }
}
