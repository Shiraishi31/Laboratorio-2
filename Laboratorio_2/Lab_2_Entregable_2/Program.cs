using System;

namespace Actividad2_LibroCalificaciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LibroCalificaciones miLibro = new LibroCalificaciones();

            Console.WriteLine("Por favor ingrese el nombre del curso: ");
            string nombreDelCurso = Console.ReadLine();

            Console.WriteLine();

            miLibro.MostrarMensaje(nombreDelCurso);

            Console.ReadKey();
        }
    }
}