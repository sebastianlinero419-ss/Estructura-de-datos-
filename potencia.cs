using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



using System;

public class HelloWorld
{
    public static void ImprimirSuma(int a, int b)
    {
        int suma = a + b;
        Console.WriteLine(suma);
    }
    public static void MostrarPotenciaX(double num1, double potencia)
    {

        double result = Math.Pow(num1, potencia);
        Console.WriteLine($"la potencia de {num1} elevado a {potencia} es : {result}");

    }

    static void ModificarValor(int n)
    {
        n = n + 1;
        Console.WriteLine($"DENTRO DEL METODO: {n}");
    }



    public static void Main(string[] args)
    {
        int x = 17, y = 23;

        ImprimirSuma(y, x);
        ImprimirSuma(1000, -1);

        MostrarPotenciaX(x, y);

        int edad = 16;
        Console.WriteLine($"antes del metodo: {edad}");
        ModificarValor(edad);
        Console.WriteLine($"Despues del metodo: {edad}");
    }

}
