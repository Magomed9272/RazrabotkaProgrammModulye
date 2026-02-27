using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
        public class Circle : IShape
        {
            public double Radius { get; set; }

            public Circle(double radius)
            {
                Radius = radius;
            }

            public double Area()
            {
                return Math.PI * Radius * Radius;
            }

            public string GetShapeInfo()
            {
                return $"Круг с радиусом {Radius}, площадь: {Area()}";
            }
        }

    }
