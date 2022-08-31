using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana2
{
    public class Rectangulo
    {
        public Vertice v1 { get; set; }
        public Vertice v2 { get; set; }
        public Vertice v3 { get; set; }
        public Vertice v4 { get; set; }

        public double Area()
        {
            double ba = Math.Sqrt(Math.Pow(v1.x - v2.x, 2) + Math.Pow(v1.y - v2.y, 2));
            double alt = Math.Sqrt(Math.Pow(v2.x - v3.x, 2) + Math.Pow(v2.y - v3.y, 2));
            double area = ba * alt;
            return area;
        }

        public double Perimetro()
        {
            double ba = Math.Sqrt(Math.Pow(v1.x - v2.x, 2) + Math.Pow(v1.y - v2.y, 2));
            double alt = Math.Sqrt(Math.Pow(v2.x - v3.x, 2) + Math.Pow(v2.y - v3.y, 2));
            double perimetro = 2 * ba + 2 * alt;
            return perimetro;
        }
    }
}