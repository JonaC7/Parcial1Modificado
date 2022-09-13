using Parcial1Modificado;
using System;
using System.Collections;

namespace Parcial
{
    class Program
    {
        private static object list;

        static void Main(string[] args)
        {
            int finProceso;
            do
            {
                int numberStudents;
                ArrayList registro = new ArrayList();
                string nombre;
                int edad;
                double nota1;
                double nota2;
                double parcial;
                double promedio;

                int contador = 0;

                Console.WriteLine("Cuantos estudiantes desea evaluar: ");
                numberStudents = int.Parse(Console.ReadLine());
                Console.WriteLine("");
                while (contador < numberStudents)
                {
                    Console.Write("Ingrese el nombre del estudiante: ");
                    nombre = Console.ReadLine();
                    Console.Write("Ingrese la edad del estudiante: ");
                    edad = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese la nota del primer laboratorio: ");
                    nota1 = double.Parse(Console.ReadLine());
                    Console.Write("Ingrese la nota del segundo laboratorio: ");
                    nota2 = double.Parse(Console.ReadLine());
                    Console.Write("Ingrese la nota del parcial: ");
                    parcial = double.Parse(Console.ReadLine());
                    Console.WriteLine("");

                    promedio = (nota1 * .3) + (nota2 * .3) + (parcial * .4);

                    Console.WriteLine("Su promedio es: {0}", promedio);
                    Console.WriteLine("");
                    if (promedio >= 6)
                    {
                        Console.WriteLine("                              ==== Aprobado ====");
                        Console.WriteLine("");
                        Console.WriteLine("------------------------------------------------------------------------------------------------------------");
                        Console.WriteLine("");
                    }
                    else
                    {
                        Console.WriteLine("                              ==== Reprobado ====");
                        Console.WriteLine("");
                        Console.WriteLine("------------------------------------------------------------------------------------------------------------");
                        Console.WriteLine("");
                    }



                    Students students = new Students() { Nombre = nombre, Edad = edad, Nota1 = nota1, Nota2 = nota2, Parcial = parcial, Promedio = promedio };
                    registro.Add(students);

                    contador++;
                }



                foreach (Students st in registro)
                {
                    Console.WriteLine(st.getData());
                }
                Console.WriteLine("");
                Console.WriteLine("====== Si desea ejecutar de nuevo coloque 0 ======");
                finProceso = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

            } while (finProceso == 0);
            Console.WriteLine("Gracias por ejecutar");
        }

    }

}