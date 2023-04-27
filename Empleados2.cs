
using System;
namespace MyApp
{
    class Empleado2
    {
        private string _nombre;
        private double _salarioBase;
        private double _bonoAnual;

        public Empleado2(string nombre, double salarioBase, double bonoAnual)
        {
            _nombre = nombre;
            _salarioBase = salarioBase;
            _bonoAnual = bonoAnual;
        }
        public void CalcularSalario()
        {
            double totalAnual = _salarioBase * 12;
        }
        public override String ToString()
        {
            return "empleado "+_nombre +" Escribo";


        }
    }
    
}