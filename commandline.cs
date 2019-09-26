//Rextester.Program.Main is the entry point for your code. Don't change it.
//Compiler version 4.0.30319.17929 for Microsoft (R) .NET Framework 4.5

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    public class Program
    {
        public static void Main(string[] args)
        {
        int maxvalue = 100;
        int partizioni = 9;
        string valorefinale = "";
        for (int i = 1; i <= maxvalue; i++)
          {
            valorefinale += i.ToString() + ",";
                        for (int j = 1; j < partizioni; j++)
                        {
                            valorefinale += (i + maxvalue * j).ToString() + ",";
                        }
          } 
        Console.WriteLine(valorefinale);
        }
    }
}
