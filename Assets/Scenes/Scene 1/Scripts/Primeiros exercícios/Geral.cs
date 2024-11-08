using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Geral : MonoBehaviour
{
    public string variavelPublica;

    [SerializeField] int vidaJogador = 10;
    void Start()
    {
        Debug.Log("Hello World");
        Debug.Log(vidaJogador);
        Debug.Log(variavelPublica);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
