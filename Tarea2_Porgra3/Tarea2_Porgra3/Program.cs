using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2_Porgra3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicitar la cantidad de camisas y el precio unitario de las camisas
            Console.Write("Ingrese la cantidad de camisas que desea comprar: ");
            int cantidadCamisas = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el precio unitario de las camisas: ");
            double precioUnitario = double.Parse(Console.ReadLine());

            // Calcular el costo unitario por camisa
            double costoUnitario = precioUnitario;

            // Calcular el descuento
            double descuento = 0.0;

            if (cantidadCamisas >= 2 && cantidadCamisas <= 5)
            {
                descuento = precioUnitario * cantidadCamisas * 0.15;
            }
            else if (cantidadCamisas > 5)
            {
                descuento = precioUnitario * cantidadCamisas * 0.20;
            }

            // Calcular el costo total
            double costoTotal = (precioUnitario * cantidadCamisas) - descuento;

            // Mostrar los resultados
            Console.WriteLine("\nResumen de la compra:");
            Console.WriteLine("Cantidad de camisas: " + cantidadCamisas);
            Console.WriteLine("Costo unitario por camisa: $" + costoUnitario);
            Console.WriteLine("Descuento aplicado: $" + descuento);
            Console.WriteLine("Costo total: $" + costoTotal);

            Console.ReadLine(); // Espera a que el usuario presione Enter para salir
        }
    }
}