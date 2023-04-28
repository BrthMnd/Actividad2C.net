namespace MyApp
{
    public class Libro2
    {
        private string _titulo;
        private string _autor;
        private int _numeroPaginas;
        private double _precio;

        public Libro2(string titulo, string autor, int numeroPaginas, double precio)
        {
            _titulo = titulo;
            _autor = autor;
            _numeroPaginas = numeroPaginas;
            _precio = precio;
        }
        public double CalcularPrecioPorPagina()
        {

            return _precio / _numeroPaginas;
        }
        public void ImprimirInfo()
        {
            Console.WriteLine("Titulo: " + _titulo);
            Console.WriteLine("Autor: " + _autor);
            Console.WriteLine("NumeroPaginas: " + _numeroPaginas);
            Console.WriteLine("Precio Por Pagina: " + CalcularPrecioPorPagina());
            Console.WriteLine();

        }
    }

}