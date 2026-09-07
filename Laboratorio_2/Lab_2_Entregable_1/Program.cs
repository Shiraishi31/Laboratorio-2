using System;

namespace Actividad1_LibroCalificaciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LibroCalificaciones miLibro = new LibroCalificaciones();

            miLibro.MostrarMensaje();

            Console.ReadKey();
        }
    }
}