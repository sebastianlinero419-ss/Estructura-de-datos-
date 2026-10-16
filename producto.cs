using System;
using System.IO;
class Program
{
    static void Main()
    {
        string ruta = "C:\\Users\\SALA-1\\Desktop\\sebastian\\productos.csv";
        using (StreamWriter sw = new StreamWriter(ruta))
        {
            sw.WriteLine("ID,Nombre,Precio");
            sw.WriteLine("1,Laptop,1200");
            sw.WriteLine("2,Mouse,250");
            sw.WriteLine("3,Monitor,300");
            sw.WriteLine("4,teclado,1900");
            sw.WriteLine("5,cpu,2300");
            sw.WriteLine("6,torre,3000");
            sw.WriteLine("7,tarjeta grafica,2500");
            
            
        }
        string[] lineas = File.ReadAllLines(ruta);
        for (int i = 1; i < lineas.Length; i++)
        {
            string[] campos = lineas[i].Split(',');
            double precio = double.Parse(campos[2]);
            if (precio > 100)
                Console.WriteLine($"{campos[1]} - ${precio}");
        }
    }
}
