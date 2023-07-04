using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public abstract class Vehiculo
    {
        public string Marca { get; }

        public string Modelo { get; }



        protected Vehiculo(string marca, string modelo)
        {
            Marca = marca;
            Modelo = marca;

        }

        //metodo virtual
        public virtual void Conducir()
        {
            Console.WriteLine($"Conduciendo el vehiculo {Marca}{Modelo}");
            Console.ReadKey();

        }

    }
}
