using System;
using System.Collections.Generic;

/// You can add a reference to a library or project targeting incompatible version of .NET Standard.
/// Intellisense does not warn you of the incompatibility
/// COMPILER WILL THROW AN ERROR UPON BUILD
using Ex_1_NetStandard;

namespace Ex_1_NetFrameworkConsoleIncompat
{
    class Program
    {
        // .NET Framework 3.5 project that implements the library targeting .NET Standard 2.0 - This will NOT work
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
            Console.WriteLine($"Euclidean distance between p and q is {Distances.Euclidean(p, q)}");
            Console.ReadKey();
        }
    }
}
