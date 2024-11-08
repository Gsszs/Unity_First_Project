using UnityEngine;

/*
(Reverter uma string) Escreva um programa que inverte uma
string usando um loop for.
*/

public class Ex8 : MonoBehaviour
{
    string nome = "Gabriel";
    string nova;
    void Start()
    {
        for (int i = nome.Length; i > 0; i--)
        {
            nova += nome[i - 1];
        }
        print(nova);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
