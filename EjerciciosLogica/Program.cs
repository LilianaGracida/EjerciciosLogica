using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosLogica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crea un objeto de la clase Rectangulo llamado rectangulo.
            Rectangulo rectangulo = new Rectangulo();
            //Establece los valores de longitud y ancho del rectángulo utilizando las propiedades.
            rectangulo.Longitud = 12.5;
            rectangulo.Ancho = 8.3;
            //Calcula el área del rectángulo llamando al método CalcularArea.
            rectangulo.CalcularArea(rectangulo.Longitud, rectangulo.Ancho);
            //Muestra el resultado del cálculo del área en la consola.
            Console.WriteLine("El area del rectangulo es:  " + rectangulo.Resultado);
            Console.ReadKey();

        }
    }
}