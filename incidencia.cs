using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Registro de incidencias de un soporte tecnico utilizando archivo (.txt) 
// 1. Guardar una lista de incidencias atendidas a un archivo de texto
// 2. Leer el archivo
// 3. Generar un reporte que cuenta cuantas incidencias hay por prioridad (Alta, Media, Baja)
// La estructura del archivo es: ID, NOMBRE, DESCRIPCION, PRIORIDAD.
namespace RegistrosIncidencias
{
    internal class Program
    {
        static string pathArchivo = "incidencias.txt";

        static void GuardarIncidencias(List<string[]> incidencias)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(pathArchivo, false))
                {
                    foreach (string[] incidencia in incidencias)
                    {
                        sw.WriteLine(incidencia);
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error al escribir el archivo: {ex.Message}");
            }
        }

        static List<string[]> LeerIncidencias()
        {
            List<string[]> incidencias = new List<string[]>();

            if (!File.Exists(pathArchivo))
            {
                Console.WriteLine("El archivo mo existe aun.");
                return incidencias;
            }
            try
            {
                string linea;
                using (StreamReader sr = new StreamReader(pathArchivo))
                {
                    while ((linea = sr.ReadLine()) != null)
                    {
                        if (!string.IsNullOrWhiteSpace(linea))
                        {
                            string[] campos = linea.Split(';');
                            incidencias.Add(campos);
                        }
                    }
                }
            }
            catch (Exception error)
            {
                Console.WriteLine($"Error el leer el archivo {error.Message}");
            }
            return incidencias;
        }



        static void Main(string[] args)
        {

        }
    }
}
