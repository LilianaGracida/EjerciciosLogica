using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosLogica
{
    public class Rectangulo
    {
        // Variables de instancia private
        private double longitud;
        private double ancho;

        // constructor que inicializa las variables en 0
        public Rectangulo()
        { 
            longitud = 0;
            ancho = 0;
        }
        //Un constructor con parámetros que permita establecer los valores de longitud y ancho
        //al momento de crear un objeto de la clase.
        public Rectangulo(double longitud, double ancho)
        {
            this.longitud = longitud;
            this.ancho = ancho;
        }
        //Propiedades públicas Longitud y Ancho que permitan acceder y modificar las variables de instancia.
        public double Longitud { get; set; }
        public double Ancho { get; set; }
        public double Resultado { get; set; }

        //Un método público llamado CalcularArea que calcule el área del rectángulo
        //(multiplicando longitud por ancho) y lo devuelva como resultado.

        public double CalcularArea(double longitud, double ancho)
        {
            Resultado = longitud* ancho;

            return Resultado;

        }


    }

}
