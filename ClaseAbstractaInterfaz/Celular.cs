using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static ClaseAbstractaInterfaz.Producto;

namespace ClaseAbstractaInterfaz
{
    public class Celular : Producto, IVendible
    {
       
            public string Marca { get; }

            // Constructor de Celular
            public Celular(int codigo, string nombre, decimal precio, string marca)
                : base(codigo, nombre, precio)
            {
                Marca = marca;
            }

            // Implementación del método MostrarInformacion() de Producto
            public override void MostrarInformacion()
            {
                Console.WriteLine($"Código: {Codigo}, Nombre: {Nombre}, Precio: {Precio:C}, Marca: {Marca}");
                Console.ReadKey();
            }

            // Implementación del método Vender() de IVendible
            public void Vender()
            {
                Console.WriteLine($"El celular {Nombre} ha sido vendido.");
                Console.ReadKey();
            }
        
    }
}
