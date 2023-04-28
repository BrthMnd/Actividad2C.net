namespace MyApp
{
    public class Libro
    {
        private string _titulo;
        private string _autor;
        private string _anoDePublicacion;
        private int _numeroPaginas;
        private int _numeroEjemplares;

        public Libro(string titulo, string autor, string anoDePublicacion, int numeroPaginas, int numeroEjemplares)
        {
            _titulo = titulo;
            _autor = autor;
            _anoDePublicacion = anoDePublicacion;
            _numeroPaginas = numeroPaginas;
            _numeroEjemplares = numeroEjemplares;
        }

        public void PrestarLibro()
        {
            _numeroEjemplares -= 1;

        }
        public void DevolverLibro()
        {
            _numeroEjemplares += 1;
        }
        public void ImprimirInfo()
        {
            Console.WriteLine("El libro " + _titulo + " escrito por " + _autor + "\n"
            + "Publicado en: " + _anoDePublicacion + " con una cantidad de paginas de " + _numeroPaginas + "\n"
            + "En la biblioteca hay: " + _numeroEjemplares + " Ejemplerares disponibles");

        }


    }
}