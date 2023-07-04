using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Automovil : Vehiculo
    {
        public int NumeroPuertas { get; }

        //constructor automoviñ
        public Automovil(string marca, string modelo, int numeroPuertas)
         : base(marca, modelo)
        {
            numeroPuertas = numeroPuertas;
        }
        //implementacion del metodo conducir
        public override void Conducir()
        {
            Console.WriteLine($"Conduciendo el automóvil {Marca} {Modelo} con {NumeroPuertas} puertas");
            Console.ReadKey();
        }
        
    }
}
