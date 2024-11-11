using System;
using UnityEngine;

/*
Fa�a um algoritmo que receba o dia, o m�s e o ano em que uma pessoa nasceu, imprima na tela quantos anos, 
meses e dias essa pessoa j� viveu. Leve em considera��o o ano com 365 dias e o m�s com 30 dias.
*/

public class Desafio2 : MonoBehaviour
{
    [SerializeField] int dia = 08;
    [SerializeField] int mes = 11;
    [SerializeField] int ano = 2006;
    [SerializeField] int diaAtual = DateTime.Now.Day;
    [SerializeField] int mesAtual = DateTime.Now.Month;
    [SerializeField] int anoAtual = DateTime.Now.Year;
    void Start()
    {
        int quantosAnos = anoAtual - ano;

        if (mesAtual < mes || (mesAtual == mes && diaAtual < dia)) { quantosAnos--; };

        int quantosMeses = (mesAtual - mes + 12) % 12;
        int quantosDias = (diaAtual - dia + 30) % 30;


        print($"Anos: {quantosAnos}");
        print($"Meses: {quantosMeses}");
        print($"Dias: {quantosDias}");

    }

    void Update()
    {
        
    }
}
