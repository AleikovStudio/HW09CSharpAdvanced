using System;
using System.Collections.Generic;

class RemoveNames
{
    static void Main()
    {
        List<string> firstList = new List<string>();//FIRST LIST OF NAMES
        string[] firstArray = Console.ReadLine().Split();

        for (int i = 0; i < firstArray.Length; i++)
        {
            firstList.Add(firstArray[i]);
        }

        List<string> secondList = new List<string>();//SECOND LIST OF NAMES
        string[] secondArray = Console.ReadLine().Split();

        for (int i = 0; i < secondArray.Length; i++)
        {
            secondList.Add(secondArray[i]);
        }

        List<string> allLists = new List<string>();//COMBINED LIST OF 1ST AND 2ND LISTS
        foreach (var VARIABLE in firstList)
        {
            if (secondList.Contains(VARIABLE))
            {
                continue;
            }
            else
            {
                allLists.Add(VARIABLE);
            }
        }
        
        foreach (var VARIABLE in allLists)
        {
            Console.Write("{0} ", VARIABLE);
        }
        Console.WriteLine();
    }
}