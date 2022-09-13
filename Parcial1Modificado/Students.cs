using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial1Modificado
{
    class Students
    {

        private string nombre;
        private int edad;
        private double notaLab1;
        private double notaLab2;
        private double parcial;
        private double promedio;

        public Students()
        {
        }

        public Students(string nombre, int edad, double notaLab1, double notaLab2, double parcial, double promedio, double promedio1)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.notaLab1 = notaLab1;
            this.notaLab2 = notaLab2;
            this.parcial = parcial;
            this.promedio = promedio;
        }

        public string Nombre { get; internal set; }
        public int Edad { get; internal set; }
        public double Nota1 { get; internal set; }
        public double Nota2 { get; internal set; }
        public double Parcial { get; internal set; }
        public double Promedio { get; internal set; }

        public string getData()
        {
            return "-Nombre: " + nombre + "  -Edad: " + edad + "  -Nota Laboratorio 1: " + notaLab1 + "  -Nota Laboratorio 2: " + notaLab2 + "  -Parcial: " + parcial + "  -Promedio: " + promedio;
        }
    }
}
