using System;
using System.Linq;
using UnityEngine;

// Escreva um programa que conta o número de consoantes em uma string.

public class Desafio1 : MonoBehaviour
{

    [SerializeField] char[] vogais = { 'a', 'e', 'i', 'o', 'u'};
    void Start()
    {
        string frase = "abcdefg";
        int consoantes = 0;
        foreach(char c in frase.ToLower())
        {
            if (vogais.Contains(c) || !Char.IsLetter(c)) { continue; }
            consoantes++;
        }
        print($"A frase \"{frase}\" tem {consoantes} consoantes.");

    }

    void Update()
    {
        
    }
}
