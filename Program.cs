using System;
using VideoClub;

class Program{
    static void Main(string[] args){
        
        Inventario archivo = new Inventario();
        archivo.LeerArchivo("archivos/peliculas.txt");
        

        Cliente cliente1 = new Cliente();

        VIDEOCLUB pedidos = new VIDEOCLUB();
        Boleta boleta = new Boleta();
        
        bool salir = false;
        while (!salir)
        {
            Console.WriteLine("===== Menú =====");
            Console.WriteLine("1. Datos cliente");
            Console.WriteLine("2. Boleta");
            Console.WriteLine("3. Peliculas seleccionadas");
            Console.WriteLine("4. Agregar 1 película");
            Console.WriteLine("5. Agregar 2 peliculas");// sobrecarga de metodo
            Console.WriteLine("6. Quitar película");// sobre carga de operador
            Console.WriteLine("7. Inventario");
            Console.WriteLine("8. Salir");
            Console.Write("Elige una opción: ");

            string? opcion = Console.ReadLine();

            switch (opcion)
            {

                case "1":
                    Console.WriteLine("=================================");
                    Console.WriteLine("Ingrese datos cliente");
                    // metodos cliente, set
                    Console.WriteLine("Ingrese nombre: ");
                    string? nombre = Console.ReadLine();
                
                    cliente1.Nombre = nombre;
                    
                    
                    Console.WriteLine("Ingrese apellido: ");
                    cliente1.Apellido = Console.ReadLine();
                    Console.WriteLine("Ingrese rut: ");
                    cliente1.RUT = Console.ReadLine();
                    Console.WriteLine("Ingrese correo: ");
                    cliente1.Correo = Console.ReadLine();

                    

                    break;

                case "2":
                    Console.WriteLine("Generando boleta.");
                    // poner el código de la boleta
                    // creara una archivo de salida, utilizar metodos get
                    
                    boleta.MostrarDetalles();
                    cliente1.MostrarInformacionCliente();
                    break;
                case "3":
                    Console.WriteLine("=========================");
                    Console.WriteLine("Peliculas seleccionadas:\n");
                    
                    pedidos.MostrarPeliculas();
                    break;
                case "4":
                    Console.WriteLine("Has elegido Agregar 1 Película");
                    Console.WriteLine("Ingrese Titulo de la Película:");
                    string? titulo = Console.ReadLine();

                    Console.WriteLine("Ingrese Género de la Película:");
                    string? genero = Console.ReadLine();
                    
                    Console.WriteLine("Ingrese Cantidad de Ejemplares:");
                    int cantidadEjemplares = Convert.ToInt32(Console.ReadLine());
                    
                    Pelicula peli = new Pelicula(titulo, genero, cantidadEjemplares);

                    pedidos.AgregarPelicula(peli);
                    archivo.ActualizarInventario(peli);

                    break;


                case "5":

                    Console.WriteLine("Has elegido Agregar 2 Película");
                    Console.WriteLine("Ingrese Titulo de la Película:");
                    string? titulo1 = Console.ReadLine();

                    Console.WriteLine("Ingrese Género de la Película:");
                    string? genero1 = Console.ReadLine();
                    
                    Console.WriteLine("Ingrese Cantidad de Ejemplares:");
                    int cantidadEjemplares1 = Convert.ToInt32(Console.ReadLine());
                    
                    Pelicula peli1 = new Pelicula(titulo1, genero1, cantidadEjemplares1);
                    pedidos.AgregarPelicula(peli1);
                    archivo.ActualizarInventario(peli1);

                    Console.WriteLine("Ingrese Titulo de la Película:");
                    string? titulo2 = Console.ReadLine();

                    Console.WriteLine("Ingrese Género de la Película:");
                    string? genero2 = Console.ReadLine();
                    
                    Console.WriteLine("Ingrese Cantidad de Ejemplares:");
                    int cantidadEjemplares2 = Convert.ToInt32(Console.ReadLine());
                    Pelicula peli2 = new Pelicula(titulo2, genero2, cantidadEjemplares2);
                    pedidos.AgregarPelicula(peli2);
                    archivo.ActualizarInventario(peli2);
                    
                    break;

                case "6":
                    Console.WriteLine("=========================");
                    Console.WriteLine("Ingrese titulo de la pelicula a quitar:");
                    //string? peliQuitar= Console.ReadLine();
                    //Pelicula quitar = new Pelicula(peliQuitar);

                    Console.WriteLine("Ingrese titulo de la pelicula a quitar:");
                    string? peliQuitar = Console.ReadLine();
                    Pelicula quitar = new Pelicula(peliQuitar);
    
                    // Aquí el operador - para quitar la película
                    pedidos = pedidos - quitar;

                    break;

                case "7":
                    Console.WriteLine("=========================");
                    archivo.MostrarInventario();

                    break;
                
                case "8":
                    Console.WriteLine("Has elegido salir. ¡Hasta luego!");
                    salir = true;
                    break;
                default:
                    Console.WriteLine("Opción no válida. Por favor, elige una opción del menú.");
                    break;
            }
        }
        
    }
}
