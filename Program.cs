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
            Console.WriteLine("4. Agregar película");
            Console.WriteLine("5. Quitar película");
            Console.WriteLine("6. Inventario");
            Console.WriteLine("7. Salir");
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

                    break;
                case "3":
                    Console.WriteLine("=========================");
                    Console.WriteLine("Peliculas seleccionadas:\n");
                    
                    pedidos.MostrarPeliculas();
                    break;
                case "4":
                    Console.WriteLine("Has elegido Agregar Película");
                    Console.WriteLine("Ingrese Titulo de la Película:");
                    string? titulo = Console.ReadLine();

                    Console.WriteLine("Ingrese Género de la Película:");
                    string? genero = Console.ReadLine();
                    
                    Console.WriteLine("Ingrese Cantidad de Ejemplares:");
                    int cantidadEjemplares = Convert.ToInt32(Console.ReadLine());
                    
                    Pelicula peli = new Pelicula(titulo, genero, cantidadEjemplares);
                    archivo.ActualizarInventario(peli);

                    pedidos.AgregarPelicula(peli);
    
                    break;


                case "5":
                    Console.WriteLine("=========================");
                    Console.WriteLine("Ingrese titulo de la pelicula a quitar:");
                    //string? peliQuitar= Console.ReadLine();
                    //Pelicula quitar = new Pelicula(peliQuitar);

                    Console.WriteLine("Ingrese titulo de la pelicula a quitar:");
                    string? peliQuitar = Console.ReadLine();
                    Pelicula quitar = new Pelicula(peliQuitar);
    
                    // Aquí usas el operador - para quitar la película
                    pedidos = pedidos - quitar;

                    break;

                case "6":
                    Console.WriteLine("=========================");
                    archivo.MostrarInventario();

                    break;
                
                case "7":
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
