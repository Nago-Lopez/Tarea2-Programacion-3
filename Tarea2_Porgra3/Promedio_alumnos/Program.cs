using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promedio_alumnos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el número de estudiantes: ");
            int numeroEstudiantes = int.Parse(Console.ReadLine());

            for (int i = 0; i < numeroEstudiantes; i++)
            {
                Console.WriteLine($"Estudiante {i + 1}:");
                Console.Write("Carnet: ");
                string carnet = Console.ReadLine();
                Console.Write("Nombre: ");
                string nombre = Console.ReadLine();
                Console.Write("Quiz 1: ");
                double quiz1 = double.Parse(Console.ReadLine());
                Console.Write("Quiz 2: ");
                double quiz2 = double.Parse(Console.ReadLine());
                Console.Write("Quiz 3: ");
                double quiz3 = double.Parse(Console.ReadLine());
                Console.Write("Tarea 1: ");
                double tarea1 = double.Parse(Console.ReadLine());
                Console.Write("Tarea 2: ");
                double tarea2 = double.Parse(Console.ReadLine());
                Console.Write("Tarea 3: ");
                double tarea3 = double.Parse(Console.ReadLine());
                Console.Write("Examen 1: ");
                double examen1 = double.Parse(Console.ReadLine());
                Console.Write("Examen 2: ");
                double examen2 = double.Parse(Console.ReadLine());
                Console.Write("Examen 3: ");
                double examen3 = double.Parse(Console.ReadLine());

                double porcentajeQuices = ((quiz1 + quiz2 + quiz3) / 3) * 0.25;
                double porcentajeTareas = ((tarea1 + tarea2 + tarea3) / 3) * 0.30;
                double porcentajeExamenes = ((examen1 + examen2 + examen3) / 3) * 0.45;

                double promedioFinal = porcentajeQuices + porcentajeTareas + porcentajeExamenes;

                string condicion = "";
                if (promedioFinal >= 70)
                {
                    condicion = "Aprobado";
                }
                else if (promedioFinal >= 50)
                {
                    condicion = "Aplazado";
                }
                else
                {
                    condicion = "Reprobado";
                }

                Console.WriteLine($"Carnet: {carnet}");
                Console.WriteLine($"Nombre: {nombre}");
                Console.WriteLine($"Porcentaje de Quices: {porcentajeQuices}%");
                Console.WriteLine($"Porcentaje de Tareas: {porcentajeTareas}%");
                Console.WriteLine($"Porcentaje de Examenes: {porcentajeExamenes}%");
                Console.WriteLine($"Promedio Final: {promedioFinal}");
                Console.WriteLine($"Condición: {condicion}");

                Console.ReadLine(); // Espera a que el usuario presione Enter para salir
            }
        }
    }
}
