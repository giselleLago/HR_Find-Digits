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

class Solution
{

    // Complete the findDigits function below.
    static int findDigits(int n)
    {
        var strN = n.ToString();
        var count = 0;
        var list = new List<string>();

        
        foreach (Char c in strN)
        {
            String cString = c.ToString();
            list.Add(cString);
        }
        for (int i = 0; i < list.Count; i++)
        {
            int a = Int32.Parse(list[i]);
            if (a != 0)
            {
                if (n % a == 0)
                {
                    count++;
                }
            }
               
        }
        return count;
    }

    static void Main(string[] args)
    {

        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int result = findDigits(n);

            Console.WriteLine(result);
            Console.ReadKey();
        }

    }
}
