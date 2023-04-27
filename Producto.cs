
using System;

namespace MyApp 
{
    
    class Producto{
        private string _nombre;
        private double _precio;
        private double _cantidad;

        public Producto(string nombre, double precio, double cantidad)
        {
            _nombre = nombre;
            _precio = precio;
            _cantidad = cantidad;
        }
        

        public void AgregarCantidad(double nuevaCantidad){

            _cantidad += nuevaCantidad;

        }
        public void QuitarCantidad(double nuevaCantidad){
            _cantidad -= nuevaCantidad;

        }
        public double CalcularTotal(){

            double Total;

            Total = _cantidad*_precio;
            return Total;
        }
        public void MostrarInformacion(){
            
            Console.WriteLine("El producto "+ _nombre+" con un precio de $"+_precio+"\n"
            +" se comprará una cantidad de "+ _cantidad+" unidades"+ "\n"
            +" Que hacen un total de "+ CalcularTotal());

        }
    }
}

    
