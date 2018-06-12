using System.Collections.Generic;
using System;
using Ex_1_NetStandard;

namespace Ex_1_NetCoreConsole
{
    class Program
    {
        // .NET Core 2.0 project that implements the library targeting .NET Standard 2.0 - This will work
        static void Main(string[] args)
        {
            List<double> p = new List<double> {
                2.5,
                2.7,
                3.5,
                7.4
            };

            List<double> q = new List<double> {
                27.5,
                12.7,
                41.5,
                35.4
            };
            Console.WriteLine($"Euclidean distance between p and q is {Distances.Euclidean(p,q)}");
            Console.ReadKey();
        }
    }
}
