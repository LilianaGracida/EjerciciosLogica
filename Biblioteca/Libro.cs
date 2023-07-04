using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Libro
    {

        private string titulo;
        private string autor;
        private int año;

        public Libro()
        {
            titulo = "";
            autor = "";
            año = 0;
        }

        public Libro(string titulo, string autor, int año)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.año = año;
        }

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }

        public int Año
        {
            get { return año; }
            set { año = value; }
        }

        public override string ToString()
        {
            return "Título: " + titulo + ", Autor: " + autor + ", Año: " + año;
        }
    }
}
