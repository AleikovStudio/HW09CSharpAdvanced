using System;
using System.Collections.Generic;

class SortingNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[] input = new int[n];

        for (int i = 0; i < n; i++)
        {
            input[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(input);

        foreach (var VARIABLE in input)
        {
            Console.WriteLine(VARIABLE);
        }

        //int n = int.Parse(Console.ReadLine());

        //List<int> input = new List<int>(n);

        //for (int i = 0; i < n; i++)
        //{
        //    int num = int.Parse(Console.ReadLine());
        //    input.Add(num);
        //}

        //input.Sort();

        //foreach (var VARIABLE in input)
        //{
        //    Console.WriteLine(VARIABLE);
        //}
    }
}