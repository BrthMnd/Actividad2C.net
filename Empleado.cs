
using System;

namespace MyApp 
{
    
    class Empleado
    {

        private string _nombre {get; set; }
        private int _edad {get; set; }
        private double _sueldo {get; set; }
        public Empleado(string nombre, int edad, double sueldo)
        {
            _nombre = nombre;
            _edad = edad;
            _sueldo = sueldo;
        }

        public void Trabajar(){
            Console.Write("Trabajando...\n");

        }
        public void Descansar(){
            Console.Write("Descansando...\n");

        }

        public void MostrarInformacion(bool option){
            Console.Write("El Empleado "+_nombre+" esta " );
            if (option){
                Trabajar();
            }
            else{
                Descansar();
            }
        }


    }

}

    
