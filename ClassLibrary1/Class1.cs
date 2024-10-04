using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    public class Сalculator
    {
        public double calculateAreaCircle(double radius)
        {
            return Math.Round((Math.PI * Math.Pow(radius, 2)),2);
        }
        public double calculateAreaTriangle(double sideFirst, double sideSecond, double sideThree)
        {
            double halfParameter = (sideFirst + sideSecond + sideThree) / 2;
            return Math.Round((Math.Sqrt(halfParameter * (halfParameter - sideFirst) * (halfParameter - sideSecond) * (halfParameter - sideThree))),2);
            checkSquareness(sideFirst, sideSecond, sideThree);
        }
        public bool checkSquareness(double sideFirst, double sideSecond, double sideThree)
        {
            List<double> doubles = new List<double>()
            {
                sideFirst, sideSecond, sideThree
            };
            double sumSqr = 0;
            double maxDig = doubles.Max();
            int indexMax = doubles.IndexOf(maxDig);
            for(int i = 0;i < doubles.Count;i++)
            {
                if (i != indexMax) sumSqr += Math.Pow(doubles[i], 2);
                
            }
            if (sumSqr == Math.Pow(doubles[indexMax], 2)) return true;
            else return false;
        }
    }
}
