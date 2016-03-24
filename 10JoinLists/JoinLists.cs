using System;
using System.Collections.Generic;

class JoinLists
{
    static void Main()
    {
        string[] firstArray = Console.ReadLine().Split();//USER INPUT 1ST ARRAY
        List<string> firstList = new List<string>();//ADD 1ST LIST

        for (int i = 0; i < firstArray.Length; i++)//POPULATE THE 1ST LIST WITH THE ELEMENTS OF THE 1ST ARRAY
        {
            firstList.Add(firstArray[i]);
        }

        string[] secondArray = Console.ReadLine().Split();//USER INPUT 2ND ARRAY
        List<string> secondList = new List<string>();//ADD 2ND LIST

        for (int i = 0; i < secondArray.Length; i++)//POPULATE THE 2ND LIST WITH THE ELEMENTS OF THE 2ND ARRAY
        {
            secondList.Add(secondArray[i]);
        }

        for (int i = 0; i < firstList.Count; i++)
        {
            if (!secondList.Contains(firstList[i]))
            {
                secondList.Add(firstList[i]);
            }
            else
            {
                continue;
            }
        }
        
        secondList.Sort();
       
        foreach (var VARIABLE in secondList)
        {
            Console.Write("{0} ",VARIABLE);
        }
        Console.WriteLine();
    }
}