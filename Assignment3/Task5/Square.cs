using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class Square:InterfaceOfCircleSquare
    {
        public double Side { get; private set; }

        public Square(double side)
        {
            Side = side;
        }

    /*    public double CalculateArea()
        {
            return Side * Side;
        }*/

        double InterfaceOfCircleSquare.CalculateArea()
        {
            return Side * Side;
        }
    }
}
