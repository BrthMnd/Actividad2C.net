namespace MyApp
{
    public class Alumno
    {
        private string _nombre;
        private double[] _notas = new double[3];

        public Alumno(string nombre, double[] notas)
        {
            _nombre = nombre;
            _notas = notas;
        }

        public double CalcularNotas()
        {
            double total = 0;
            for (int i = 0; i < _notas.Length; i++)
            {
                total += _notas[i];
            }
            return total / 3;
        }
        public void ImprimirInfo()
        {
            Console.WriteLine("El alumno: " + _nombre + " tiene un promedio de " + CalcularNotas());
        }
    }

}