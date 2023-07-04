using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Biblioteca : Libro
    {
        private List<Libro> libros;

        public Biblioteca()
        {
            libros = new List<Libro>();
        }

        public void AgregarLibro(Libro libro)
        {
            libros.Add(libro);
        }

        public List<Libro> BuscarLibrosPorAutor(string autor)
        {
            List<Libro> librosEncontrados = new List<Libro>();

            foreach (Libro libro in libros)
            {
                if (libro.Autor.Equals(autor))
                {
                    librosEncontrados.Add(libro);
                }
            }

            return librosEncontrados;
        }

        public List<Libro> BuscarLibrosPorAño(int año)
        {
            List<Libro> librosEncontrados = new List<Libro>();

            foreach (Libro libro in libros)
            {
                if (libro.Año == año)
                {
                    librosEncontrados.Add(libro);
                }
            }

            return librosEncontrados;
        }

        public void MostrarLibros()
        {
            foreach (Libro libro in libros)
            {
                Console.WriteLine(libro.ToString());
            }
        }
    }
}
