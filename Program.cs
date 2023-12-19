using System;
using System.Linq.Expressions;
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
                    cliente1.Nombre = Console.ReadLine()!.ToUpper();;
                    Console.WriteLine("Ingrese apellido: ");
                    cliente1.Apellido = Console.ReadLine()!.ToUpper();
                    Console.WriteLine("Ingrese rut: ");
                    cliente1.RUT = Console.ReadLine()!.ToUpper();
                    Console.WriteLine("Ingrese correo: ");
                    cliente1.Correo = Console.ReadLine()!.ToUpper();
                    Console.WriteLine("Ingrese forma de pago: ");
                    cliente1.FormadePago = Console.ReadLine()!.ToUpper();

                    break;

                case "2":
                    Console.WriteLine("=========================");
                    Console.WriteLine("Generando boleta.");
                    using (StreamWriter sw = new StreamWriter("archivos/boleta.txt"))
                    {
                        

                        //sw.WriteLine("Detalles de la boleta:");
                        sw.WriteLine(boleta.MostrarDetalles());

                        sw.WriteLine(cliente1.MostrarInformacionCliente());

                        pedidos.MostrarPeliculas1(sw);

                        sw.WriteLine(pedidos.PrecioTotal());
                      
                        sw.WriteLine("Fecha: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                    }
                    Console.WriteLine("Boleta generada exitosamente.");

                    break;
                case "3":
                    Console.WriteLine("=========================");
                    Console.WriteLine("Peliculas seleccionadas:\n");
                    
                    pedidos.MostrarPeliculas();
                    break;
                case "4":

                    try{
                        Console.WriteLine("=========================");
                        Console.WriteLine("Has elegido Agregar 1 Película");
                        Console.WriteLine("=========================");
                        Console.WriteLine("Ingrese Titulo de la Película:");
                        string? titulo = Console.ReadLine()!.ToUpper();

                        Console.WriteLine("Ingrese Género de la Película:");
                        string? genero = Console.ReadLine()!.ToUpper();
                    
                        Console.WriteLine("Ingrese Cantidad de Ejemplares:");
                        int cantidadEjemplares = Convert.ToInt32(Console.ReadLine());
                    
                        Pelicula peli = new Pelicula(titulo, genero, cantidadEjemplares);
                        
                        if (peli.CantidadEjemplares  <= 0 || peli.CantidadEjemplares > 3){
                            Console.WriteLine("La Cantidad maxima de ejemplares es 2");
                        }
                        else{
                            pedidos.AgregarPelicula(peli);
                            archivo.ActualizarInventario(peli);
                        }
                        
                    }catch (FormatException){
                        Console.WriteLine("Error: Ingrese un número válido para la cantidad de ejemplares.");
                    }
                    
                    

                    break;


                case "5":
                    try
                    {
                        Console.WriteLine("=========================");
                        Console.WriteLine("Has elegido Agregar 2 Películas");
                        Console.WriteLine("=========================");
                        Console.WriteLine("Ingrese Titulo de la Película:");
                        string titulo1 = Console.ReadLine()!.ToUpper();
                        Console.WriteLine("Ingrese Género de la Película:");
                        string? genero1 = Console.ReadLine()!.ToUpper();
                        Console.WriteLine("Ingrese Cantidad de Ejemplares:");
                        int cantidadEjemplares1 = Convert.ToInt32(Console.ReadLine());
                        Pelicula peli1 = new Pelicula(titulo1, genero1, cantidadEjemplares1);
                        Console.WriteLine("Ingrese Titulo de la Película:");
                        string? titulo2 = Console.ReadLine()!.ToUpper();
                        Console.WriteLine("Ingrese Género de la Película:");
                        string? genero2 = Console.ReadLine()!.ToUpper();
                        Console.WriteLine("Ingrese Cantidad de Ejemplares:");
                        int cantidadEjemplares2 = Convert.ToInt32(Console.ReadLine());
                        Pelicula peli2 = new Pelicula(titulo2, genero2, cantidadEjemplares2);
                        if (peli1.CantidadEjemplares > 3 || peli2.CantidadEjemplares > 3 || peli1.Titulo == peli2.Titulo
                        || peli1.CantidadEjemplares <=0 || peli2.CantidadEjemplares <=0){
                            Console.WriteLine("La Cantidad maxima de ejemplares es 2 o se ingreso dos peliculas con el mismo titulo");
                        }
                        else{
                            pedidos.AgregarPelicula(peli2, peli1);
                            archivo.ActualizarInventario(peli1);
                            archivo.ActualizarInventario(peli2);
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Error: Ingrese un número válido para la cantidad de ejemplares.");
                    }
                    break;

                case "6":
                    Console.WriteLine("=========================");
                    Console.WriteLine("Ingrese titulo de la pelicula a quitar:");
                    string? peliQuitar = Console.ReadLine()!.ToUpper();
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
