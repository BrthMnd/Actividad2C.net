namespace MyApp
{
    class Persona
    {
        private string _nombre { get; set; }
        private double _edad { get; set; }
        private List<Persona> _amigos { get; set; }

        public Persona(string nombre, double edad)
        {
            _nombre = nombre;
            _edad = edad;
            _amigos = new List<Persona>();
        }
        public void AgregarAmigo(Persona amigo)
        {
            _amigos.Add(amigo);
            amigo._amigos.Add(this);
        }

        public void ImprimirInfo()
        {
            Console.WriteLine("Nombre: " + _nombre);
            Console.WriteLine("Edad: " + _edad);
            foreach (var ami in _amigos)
            {

                Console.WriteLine("amigo: " + ami._nombre.ToString());


            }
        }
    }

}