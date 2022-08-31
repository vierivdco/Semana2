using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("v4------------------v3");
            Console.WriteLine(" |                  |");
            Console.WriteLine(" |                  |");
            Console.WriteLine(" |                  |");
            Console.WriteLine("v1------------------v2");

            Rectangulo rectangulo = new Rectangulo();

            rectangulo.v1 = new Vertice { x = 3, y = 7 };

            rectangulo.v2 = new Vertice { x = 8, y = 7 };

            rectangulo.v3 = new Vertice { x = 8, y = 3 };

            rectangulo.v4 = new Vertice { x = 3, y = 3 };

            Console.WriteLine("El Area es: ");
            Console.WriteLine(rectangulo.Area());

            Console.WriteLine("El Perímetro es: ");
            Console.WriteLine(rectangulo.Perimetro());

            Console.Read();
        }
    }
}