using System;
using System.IO;

class Program
{
    static void Main()
    {
        string ruta = "studin.csv";

        using (StreamWriter sw = new StreamWriter(ruta))
        {
            sw.WriteLine("Nombre,Edad,Nota");
            sw.WriteLine("lucas,20,85");
            sw.WriteLine("moises,22,90");
            sw.WriteLine("luisa,21,78");
        }

        Console.WriteLine("Archivo creado exitosamente.");
    }
}
