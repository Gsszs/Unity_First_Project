using UnityEngine;

/*
(Maior número em uma lista) Dada uma lista de números,
encontre o maior valor.
*/

public class Ex7 : MonoBehaviour
{
    int[] nums = { 12, 69, 88, 86, 78, 65 };
    void Start()
    {
        int maior = 0;
        foreach(int num in nums)
        {
            if (num > maior) { maior = num; }
        }
        print(maior);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
