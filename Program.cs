using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{


    public static void plusMinus(List<int> arr)
    {
        int positive = 0;
        int negative = 0;
        int zeros = 0;
        int total = arr.Count();
        foreach(int i in arr)
        {
            if (i > 0)
            {
                positive++;
            }
            else if(i< 0)
            {
                negative++;
            }
            else if (i == 0)
            {
                zeros++;
            }
        }

        Console.WriteLine(((float)positive / total).ToString("N6"));
        Console.WriteLine(((float)negative / total).ToString("N6"));
        Console.WriteLine(((float)zeros / total).ToString("N6"));

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}
