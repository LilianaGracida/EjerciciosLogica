using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Automovil automovil = new Automovil("Nissan", "Versa", 4);
            Camion camion = new Camion("Volvo", "FF30", 20.5m);
            // Crear un arreglo de tipo Vehiculo y agregar los objetos de Automovil y Camion
            Vehiculo[] vehiculos = { automovil, camion };

            // Iterar sobre los elementos del arreglo y llamar al método Conducir() de cada vehículo
            foreach (Vehiculo vehiculo in vehiculos)
            {
                vehiculo.Conducir();
            }
            Console.ReadKey();
        }
    }
}
