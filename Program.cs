
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp 
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            // Empleado empleados1 = new Empleado("Brandon",19,4800.5);
            // Empleado empleados2 = new Empleado("vetulio",22,4900.5);

            // empleados1.MostrarInformacion(true);
            // empleados2.MostrarInformacion(false);


            // Producto productos1 = new Producto("Manzana", 5, 50);
            
            
            // productos1.AgregarCantidad(40);
            // productos1.QuitarCantidad(20);
            // productos1.MostrarInformacion();
            
            // Producto productos2 = new Producto("Pera", 20, 10);
            // productos2.AgregarCantidad(40);
            // productos2.QuitarCantidad(20);
            // productos2.MostrarInformacion();

            Empleado2 empleado2s = new Empleado2("Guillermo",1200.0,500.0);
            

            Console.WriteLine(empleado2s.ToString());




            

        }
    }
}