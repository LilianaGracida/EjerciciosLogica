using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Camion:Vehiculo
    {

        public decimal CapacidadCarga { get; }
        public Camion(string marca, string modelo, decimal capacidadCarga)
    : base(marca, modelo)
        {
            CapacidadCarga = capacidadCarga;
        }
        public override void Conducir()
        {
            Console.WriteLine($"Conduciendo el camión {Marca} {Modelo} con capacidad de carga {CapacidadCarga} toneladas");
            Console.ReadKey();
        }

    }
}
