using System.Collections.Generic;
using System;

namespace Ex_1_NetStandard
{
    public class Distances
    {
        //Implementation of functions of a .NET Standard library
        public static double Euclidean(List<double> p, List<double> q)
        {
            if(p.Count != q.Count)
                throw new InconsistentListSizeException();
            return Math.Pow(DistanceQuadrate(p, q),1/2f);
        }
        public static double Mahalanobis(List<double> p, List<double> q)
        {
            return 0;
        }

        public static double Chebyshev(List<double> p, List<double> q)
        {
            return 0;
        }

        public static double Hemming(List<double> p, List<double> q)
        {
            return 0;
        }
        private static double DistanceQuadrate(List<double> p, List<double> q)
        {
            double result = 0;
            for (int i = 0; i < p.Count; i++)
            {
                result += Math.Pow(p[i] - q[i], 2);
            }
            return result;
        }
    }
}
