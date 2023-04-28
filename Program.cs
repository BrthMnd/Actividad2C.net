
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
            // * 1.
            // Empleado empleados1 = new Empleado("Brandon",19,4800.5);
            // Empleado empleados2 = new Empleado("vetulio",22,4900.5);

            // empleados1.MostrarInformacion(true);
            // empleados2.MostrarInformacion(false);

            // * 2.
            // Producto productos1 = new Producto("Manzana", 5, 50);
            // Producto productos2 = new Producto("Pera", 20, 10);


            // productos1.AgregarCantidad(40);
            // productos1.QuitarCantidad(20);
            // productos1.CambiarPrecio(63);
            // productos1.MostrarInformacion();

            // productos2.AgregarCantidad(40);
            // productos2.QuitarCantidad(20);
            // productos2.MostrarInformacion();

            // * 3. 
            // Empleado2 empleado2s = new Empleado2("Guillermo", 1200.0, 500.0);

            // Console.WriteLine(empleado2s.ToString());
            // * 4.
            // Libro libro = new Libro("Ciudades de Papel", "Jhon Wick", "24/04/2022", 350, 8);

            // libro.ImprimirInfo();
            // libro.PrestarLibro();

            // libro.ImprimirInfo();
            // libro.DevolverLibro();

            // libro.ImprimirInfo();
            // * 5.
            // Alumno alumno1 = new Alumno("Juan", new double[] { 3.3, 4.4, 5.2 });
            // alumno1.ImprimirInfo();

            // Alumno alumno2 = new Alumno("Karla", new double[] { 2.4, 2.4, 3.5 });
            // alumno2.ImprimirInfo();

            // * 6.
            // Producto2[] productos = new Producto2[]
            // {
            //     new Producto2("Manzana", 10.5, 100),
            //     new Producto2("Pera", 15.75, 50),
            //     new Producto2("Piña", 20.0, 200),
            // };

            // foreach (var producto in productos)
            // {
            //     producto.ImprimirInfo();
            //     Console.WriteLine();
            // }
            // * 7.
            Libro2[] libro = new Libro2[]{
                new Libro2("Harry Potter", "J.k Roblin", 346, 30000 ),
                new Libro2("El señor de los anillos", "Vetulio Alcaheda", 503, 50000 ),
                new Libro2("EL principito", "Don Duf", 236, 90000 )
            };
            foreach (var le in libro)
            {
                le.ImprimirInfo();
            }
            // * 8.
            Persona persona1 = new Persona("Juan", 30);
            Persona persona2 = new Persona("Maria", 25);
            Persona persona3 = new Persona("Pedro", 35);

            persona1.AgregarAmigo(persona2);
            persona2.AgregarAmigo(persona3);

            persona1.ImprimirInfo();
            persona2.ImprimirInfo();
            persona3.ImprimirInfo();

        }
    }
}