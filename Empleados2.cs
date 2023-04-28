
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
        public double CalcularSalario()
        {
            double totalAnual = _salarioBase * 12;
            return totalAnual;
        }
        public override String ToString()
        {
            return "Empleado: " + _nombre + " Con un salario de  $" + _salarioBase + "\n"
            + "Con un total anual de $" + CalcularSalario() + "\n"
            + "Y con un Bono anual de $" + _bonoAnual;


        }
    }

}