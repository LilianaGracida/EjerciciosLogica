using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClaseAbstractaInterfaz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Celular celular = new Celular(1234, "Xiaomi", 7000, "XIaomi");

            // Llamar al método MostrarInformacion() para mostrar la información del celular
            celular.MostrarInformacion();

            // Llamar al método Vender()
            celular.Vender();
            Console.ReadKey();

        }
    }
}
