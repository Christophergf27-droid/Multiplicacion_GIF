using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoRectangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            int baserectangulo, altura, area;
            Console.WriteLine("ingrese la base del rectangulo: ");
            baserectangulo = int.Parse(Console.ReadLine());

            Console.WriteLine("ingerese la altura del rectangulo: ");
            altura = int.Parse(Console.ReadLine());

            area = baserectangulo * altura;
            Console.WriteLine("el area del rectangulo es: " + area);
        }
    }
}
