1. crea una clase Empleado que tiene tres campos privados (nombre, edad y sueldo),
   un constructor que recibe estos tres valores y los asigna a los campos
   correspondientes, y tres métodos públicos (Trabajar(), Descansar() y
   MostrarInformacion()) que imprimen información sobre el empleado. Luego, en el
   método Main(), se crean dos objetos Empleado utilizando el constructor, se utiliza
   el método MostrarInformacion() para mostrar la información de cada empleado, y
   se llama a los métodos Trabajar() y Descansar() para simular la actividad laboral
   de cada empleado.

2. crea una clase Producto que tiene tres campos privados (nombre, precio y
   cantidad), un constructor que recibe estos tres valores y los asigna a los campos
   correspondientes, y varios métodos públicos que realizan diferentes operaciones
   con el producto. Los métodos AgregarCantidad() y QuitarCantidad() permiten
   aumentar o disminuir la cantidad de unidades del producto, respectivamente. El
   método CalcularTotal() calcula el valor total del producto multiplicando el precio
   por la cantidad. El método MostrarInformacion() muestra información sobre el
   producto, incluyendo el nombre, precio, cantidad y total.
   Luego, en el método Main(), se crean dos objetos Producto utilizando el
   constructor, se utiliza el método MostrarInformacion() para mostrar la información
   de cada producto, se llama a los métodos AgregarCantidad() y QuitarCantidad()
   para modificar la cantidad de unidades de los productos, y se modifica el precio del
   producto 1 utilizando la propiedad Precio.

3. modelar una clase Empleado que tenga un nombre, un salario base, un bono anual
   y un método para calcular el salario total anual. Además, queremos que la clase
   tenga un método ToString() que imprima información sobre el objeto Empleado.
   crea una clase Empleado que tiene tres campos privados (nombre, salarioBase y
   bonoAnual) que representan el nombre del empleado, el salario base y el bono
   anual, respectivamente. Además, tiene un constructor que recibe estos tres
   valores y los asigna a los campos correspondientes, y dos métodos públicos
   (CalcularSalarioTotal() y ToString()) que permiten calcular el salario total anual
   y mostrar información sobre el objeto, respectivamente.
   En el método Main(), se crea un objeto Empleado utilizando el constructor, y se
   imprime información sobre el objeto llamando al método ToString(). Este
   resultado se obtiene gracias a la implementación del método ToString() en la
   clase Empleado, que devuelve una cadena de texto con la información del objeto.

4. modelar una clase Libro que tenga un título, un autor, un año de publicación, un
   número de páginas y un número de ejemplares disponibles en la biblioteca.
   Además, queremos que la clase tenga métodos para prestar y devolver el libro, y
   para imprimir su información en la pantalla. crea una clase Libro que tiene cinco
   campos privados (titulo, autor, anioPublicacion, numPaginas y numEjemplares)
   que representan el título, el autor, el año de publicación, el número de páginas y el
   número de ejemplares disponibles en la biblioteca, un constructor que recibe estos
   cinco valores y los asigna a los campos correspondientes, y tres métodos
   (Prestar(), Devolver() e ImprimirInformacion()) que permiten prestar o devolver
   el libro y imprimir su información en la pantalla.
   En el método Main(), se crea un objeto Libro utilizando el constructor, se imprime
   su información utilizando el método ImprimirInformacion(), se presta el libro
   utilizando el método Prestar(), se imprime la información actualizada del libro
   utilizando el método ImprimirInformacion(), se devuelve el libro utilizando el
   método Devolver(), y se imprime la información actualizada del libro utilizando el
   método ImprimirInformacion().

5. modelar una clase Alumno que tenga un nombre y una lista de notas, y queremos
   que la clase tenga métodos para calcular el promedio de notas y para imprimir la
   información del alumno en la pantalla, creamos la clase Alumno con un constructor
   que recibe el nombre del alumno y un array de notas, y dos métodos:
   CalcularPromedio, que calcula el promedio de notas del alumno, y
   ImprimirInformacion, que imprime en pantalla el nombre del alumno, sus notas y
   su promedio.
   Luego, en la clase Program, creamos dos objetos Alumno con nombres y notas
   diferentes y llamamos al método ImprimirInformacion para cada uno de ellos.

6. modelar una clase Producto que tenga un nombre, un precio y un inventario
   disponible, y queremos que la clase tenga métodos para calcular el valor total del
   inventario y para imprimir la información del producto en la pantalla. creamos la
   clase Producto con un constructor que recibe el nombre del producto, el precio y el
   inventario disponible, y dos métodos: CalcularValorTotalInventario, que calcula
   el valor total del inventario del producto, y ImprimirInformacion, que imprime en
   pantalla el nombre del producto, el precio, el inventario disponible y el valor total
   del inventario.
   en la clase Program, creamos un array de 3 objetos Producto con diferentes
   nombres, precios e inventarios, y utilizamos un bucle foreach para llamar al
   método ImprimirInformacion para cada uno de ellos.

7. modelar una clase Libro que tenga un título, un autor, un número de páginas y un
   precio, y queremos que la clase tenga métodos para calcular el precio por página y
   para imprimir la información del libro en la pantalla. Además, vamos a crear un
   array de libros y a utilizar un bucle para imprimir la información de cada libro.
   creamos la clase Libro con un constructor que recibe el título del libro, el autor, el
   número de páginas y el precio, y dos métodos: CalcularPrecioPorPagina, que
   calcula el precio por página del libro, y ImprimirInformacion, que imprime en
   pantalla el título del libro, el autor, el número de páginas, el precio y el precio por
   página.
   en la clase Program, creamos un array de 3 objetos Libro con diferentes títulos,
   autores, números de páginas y precios, y utilizamos un bucle foreach para llamar
   al método ImprimirInformacion para cada uno de ellos.
   
8. modelar una clase Persona que tenga un nombre, una edad y una lista de amigos,
   y queremos que la clase tenga un método para agregar amigos y otro método para
   imprimir la información de la persona en la pantalla.
   creamos la clase Persona con un constructor que recibe el nombre de la persona y
   la edad, y una lista de amigos que inicializamos con un array vacío. Además,
   agregamos un método AgregarAmigo que recibe una persona y la agrega a la lista
   de amigos de la persona, y un método ImprimirInformacion que imprime en
   pantalla el nombre, la edad y la lista de amigos de la persona.
   Luego, en la clase Program, creamos tres objetos Persona con diferentes nombres
   y edades, y utilizamos el método AgregarAmigo para agregar amigos entre ellos.
   Finalmente, utilizamos el método ImprimirInformacion para imprimir la
   información de cada una de las personas en la pantalla.
