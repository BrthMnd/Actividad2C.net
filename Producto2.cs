namespace MyApp
{
    class Producto2
    {
        private string _nombre;
        private double _precio;
        private double _inventarioDisponible;

        public Producto2(string nombre, double precio, double inventarioDisponible)
        {
            _nombre = nombre;
            _precio = precio;
            _inventarioDisponible = inventarioDisponible;
        }
        public double CalcularValorTotalInventario()
        {
            double total = _precio * _inventarioDisponible;
            return total;


        }
        public void ImprimirInfo()
        {
            Console.WriteLine("Producto: " + _nombre + " precio: " + _precio + "\n"
            + "Inventario: " + _inventarioDisponible + " total: $" + CalcularValorTotalInventario());

        }
    }

}