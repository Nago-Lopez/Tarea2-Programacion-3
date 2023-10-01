using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Productos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de artículos comprados: ");
            int cantidad = int.Parse(Console.ReadLine());

            int precio_por_producto;
            int total;

            if (cantidad <= 10)
            {
                precio_por_producto = 20;
            }
            else
            {
                precio_por_producto = 15;
            }

            total = cantidad * precio_por_producto;

            Console.WriteLine("Precio por producto: $" + precio_por_producto);
            Console.WriteLine("Total a pagar: $" + total);

            Console.ReadLine(); // Espera a que el usuario presione Enter para salir

        }
    }
}
