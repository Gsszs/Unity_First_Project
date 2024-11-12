using System;
using UnityEngine;

/*
(Maior n�mero em uma lista) Dada uma lista de n�meros,
encontre o maior valor.
*/

public class Ex7 : MonoBehaviour
{
    [SerializeField] int[] nums = { 12, 69, 88, 86, 78, 65 };
    void Start()
    {
        Array.Sort(nums);
        Array.Reverse(nums);
        print($"Maior n�mero {nums[0]}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
