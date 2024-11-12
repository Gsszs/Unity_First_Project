using System;
using UnityEngine;

/*
(Maior número em uma lista) Dada uma lista de números,
encontre o maior valor.
*/

public class Ex7 : MonoBehaviour
{
    [SerializeField] int[] nums = { 12, 69, 88, 86, 78, 65 };
    void Start()
    {
        Array.Sort(nums);
        Array.Reverse(nums);
        print($"Maior número {nums[0]}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
