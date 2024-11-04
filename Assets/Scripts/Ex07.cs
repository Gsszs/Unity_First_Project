using UnityEngine;

/*
(Dado com N faces) Para fazer um jogo de RPG, vamos precisar
calcular probabilidades e simular a rolagem de dados. Crie um
script em que o usuário defina o número de faces de um dado
(int) e calcule a rolagem de um dado com esse número de faces.
Use a função abaixo para o cálculo: Random.Range (valor_min,
valor_max); (Coloque o código dentro da função-evento Start).
*/

public class Ex07 : MonoBehaviour
{
    [SerializeField] float faces = 10;
    
    void Start()
    {
        print(Random.Range(1, faces));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
