using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplicacion_GIF
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, r;
            Console.WriteLine("ingrese 2 numeros: ");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());

            r = n1 * n2;
            Console.WriteLine("El resultado de la muultiplicacion es: "+r);
        }
    }
}