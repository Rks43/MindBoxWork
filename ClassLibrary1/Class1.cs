using System;
using System.Collections.Generic;
using System.Linq;
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
        }
    }
}
