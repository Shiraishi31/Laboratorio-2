using System;

namespace Actividad3_LibroCalificaciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LibroCalificaciones miLibro1 =
                new LibroCalificaciones("Programación en C#");

            LibroCalificaciones miLibro2 =
                new LibroCalificaciones("Estructuras de Datos");

            Console.WriteLine("El nombre del curso es: {0}",
                miLibro1.NombreCurso);

            Console.WriteLine("El nombre del curso es: {0}",
                miLibro2.NombreCurso);

            Console.WriteLine();

            Console.WriteLine("Escriba el nombre del curso:");
            string nuevoCurso = Console.ReadLine();

            miLibro1.NombreCurso = nuevoCurso;

            Console.WriteLine();

            Console.WriteLine("El nombre del curso es: {0}",
                miLibro1.NombreCurso);

            miLibro1.MostrarMensaje();

            Console.ReadKey();
        }
    }
}