namespace Parcial
{
    internal class students
    {
        private string nombre;
        private int edad;
        private double nota1;
        private double nota2;
        private double parcial;
        private double promedio;

        public students(string nombre, int edad, double nota1, double nota2, double parcial, double promedio)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.nota1 = nota1;
            this.nota2 = nota2;
            this.parcial = parcial;
            this.promedio = promedio;
        }
    }
}