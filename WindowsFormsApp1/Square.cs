using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Square : IShape
    {
        public double Side { get; set; }

        public Square(double side)
        {
            Side = side;
        }

        public double Area()
        {
            return Side * Side;
        }

        public string GetShapeInfo()
        {
            return $"Квадрат со стороной {Side}, площадь: {Area()}";
        }
    }
}

