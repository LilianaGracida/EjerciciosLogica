using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseAbstractaInterfaz
{
    public abstract class Producto
    {
        // se declara las propiedades 
        public int Codigo { get; }
        public string Nombre { get; }
        public decimal Precio { get; }

        // Constructor protegido
        protected Producto(int codigo, string nombre, decimal precio)
        {
            Codigo = codigo;
            Nombre = nombre;
            Precio = precio;
        }

        // Método abstracto
        public abstract void MostrarInformacion();
    

    // Paso 2: Interfaz IVendible
    public interface IVendible
    {
        void Vender();
    }

    }
 }

