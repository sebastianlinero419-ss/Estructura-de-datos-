using System;

class Program
{
    static void Main()
    {
        // Número dado en clase
        const int CANTIDAD_ESTUDIANTES = 19;

        // Arreglos paralelos estáticos
        string[] nombres = new string[CANTIDAD_ESTUDIANTES];
        double[] calificaciones = new double[CANTIDAD_ESTUDIANTES];

        // Registro de estudiantes
        for (int i = 0; i < CANTIDAD_ESTUDIANTES; i++)
        {
            Console.WriteLine("\nEstudiante #" + (i + 1));

            // Validar nombre
            for (int intento = 0; intento < int.MaxValue; intento++)
            {
                Console.Write("Ingrese el nombre: ");
                string nombre = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(nombre))
                {
                    nombres[i] = nombre;
                    break;
                }

                Console.WriteLine("Error: el nombre no puede estar vacio.");
            }

            // Validar calificacion
            for (int intento = 0; intento < int.MaxValue; intento++)
            {
                Console.Write("Ingrese la calificacion (0.0 - 5.0): ");
                string entrada = Console.ReadLine();

                double nota;

                if (double.TryParse(entrada, out nota) &&
                    nota >= 0.0 && nota <= 5.0)
                {
                    calificaciones[i] = nota;
                    break;
                }

                Console.WriteLine(
                    "Error: ingrese una nota valida entre 0.0 y 5.0."
                );
            }
        }

        // Variables para las estadisticas
        double suma = 0;
        double notaMayor = calificaciones[0];
        double notaMenor = calificaciones[0];
        int aprobados = 0;
        int reprobados = 0;

        // Calcular estadisticas
        for (int i = 0; i < CANTIDAD_ESTUDIANTES; i++)
        {
            suma = suma + calificaciones[i];

            if (calificaciones[i] > notaMayor)
            {
                notaMayor = calificaciones[i];
            }

            if (calificaciones[i] < notaMenor)
            {
                notaMenor = calificaciones[i];
            }

            if (calificaciones[i] >= 3.0)
            {
                aprobados++;
            }
            else
            {
                reprobados++;
            }
        }

        // Calcular promedio
        double promedio = suma / CANTIDAD_ESTUDIANTES;

        // Reporte final
        Console.WriteLine("\n=================================");
        Console.WriteLine("       REPORTE DE CALIFICACIONES");
        Console.WriteLine("=================================");

        for (int i = 0; i < CANTIDAD_ESTUDIANTES; i++)
        {
            Console.WriteLine(
                nombres[i] + ": " + calificaciones[i].ToString("F2")
            );
        }

        Console.WriteLine("---------------------------------");
        Console.WriteLine("Promedio: " + promedio.ToString("F2"));
        Console.WriteLine("Nota mayor: " + notaMayor.ToString("F2"));
        Console.WriteLine("Nota menor: " + notaMenor.ToString("F2"));
        Console.WriteLine("Aprobados: " + aprobados);
        Console.WriteLine("Reprobados: " + reprobados);
        Console.WriteLine("=================================");

        Console.ReadKey();
    }
}
