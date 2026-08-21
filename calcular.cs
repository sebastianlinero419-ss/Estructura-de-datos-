using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo
{
    internal class Program
    {
        static double calcularAreaCirculo(double radio)
        {
            const double PI = 3.141592;
            //ahora voy a revisar el calculo de la formula
            double area = PI * Math.Pow(radio, 2);
            return area;
        }






        static void Main(string[] args)
        {
            Console.WriteLine("ingrese el radio del circulo");
            double r = Convert.ToDouble(Console.ReadLine());

            double result = calcularAreaCirculo(r);
            Console.WriteLine($"el area es: {result:f2}");
            
                
        }
    }
}
