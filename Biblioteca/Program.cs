using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca = new Biblioteca();


            Libro libro1 = new Libro("Pricipito ", "Solazo", 1200);
            Libro libro2 = new Libro("Diario de ana frank", "Ana Frank", 1945);
            Libro libro3 = new Libro("Anuna", "Maria del solar", 1990);

            biblioteca.AgregarLibro(libro1);
            biblioteca.AgregarLibro(libro2);
            biblioteca.AgregarLibro(libro3);

            Console.WriteLine("Libro en la biblioteca:");
            biblioteca.MostrarLibros();

            string autorBusqueda = "Solano";
            Console.WriteLine("\nLibros encontrados del autor \"" + autorBusqueda + "\":");
            List<Libro> librosPorAutor = biblioteca.BuscarLibrosPorAutor(autorBusqueda);
            foreach (Libro libro in librosPorAutor)
            {
                Console.WriteLine(libro.ToString());
            }

            int añoBusqueda = 1945;
            Console.WriteLine("\nLibros encontrados publicados en el año " + añoBusqueda + ":");
            List<Libro> librosPorAño = biblioteca.BuscarLibrosPorAño(añoBusqueda);
            foreach (Libro libro in librosPorAño)
            {
                Console.WriteLine(libro.ToString());
                Console.ReadLine();
            }
        }
    }
}
    